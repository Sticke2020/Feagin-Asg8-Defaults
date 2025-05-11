using Feagin_Asg10_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public static class LeaseDB
{
    public static List<Lease> getLeases(byte statusTypeID)
    {
        List<Lease> listLeases = new List<Lease>();
        String sqlSelect = "SELECT * FROM fnLeaseListAsTable(@StatusTypeID, @APIKey) order by DateUpdated desc";

        using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
        using (SqlCommand sqlCommand = new SqlCommand(sqlSelect, sqlConnection))
        {
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@StatusTypeID", statusTypeID);
            sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

            sqlConnection.Open();
            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Lease lease = new Lease
                    {
                        Id = (int)dataReader["ID"],
                        PropertyID = (int)dataReader["PropertyID"],
                        TenantID = (int)dataReader["TenantID"],
                        DateUpdated = (DateTime)dataReader["DateUpdated"],
                        Description = dataReader["LeaseDescription"].ToString(),
                        StatusTypeID = (byte)dataReader["StatusTypeID"]
                    };
                    listLeases.Add(lease);
                }
            }
        }
       
        return listLeases;
    }

    public static Lease getLeaseByID(int id)
    {
        Lease lease = new Lease();

        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spLeaseSelect", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        lease.Id = (int)dataReader["ID"];
                        lease.PropertyID = (int)dataReader["PropertyID"];
                        lease.TenantID = (int)dataReader["TenantID"];
                        lease.DateLeaseStarts = (DateTime)dataReader["DateLeaseStarted"];
                        lease.DateLeaseEnds = (DateTime)dataReader["DateLeaseEnds"];
                        lease.MonthlyRate = (Decimal)dataReader["MonthlyRate"];
                        lease.Notes = dataReader["Notes"].ToString();
                        lease.Description = dataReader["Description"].ToString();
                        lease.StatusTypeID = (byte)dataReader["StatusTypeID"];
                        lease.DateAdded = (DateTime)dataReader["DateAdded"];
                        lease.DateUpdated = (DateTime)dataReader["DateUpdated"];
                        lease.AddedByID = (int)dataReader["AddedByEmployeeID"];
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error retrieving lease by ID.", ex);
        }

        return lease;
    }

    public static void updateLease(Lease lease)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spLeaseUpdate", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID", lease.Id);
                sqlCommand.Parameters.AddWithValue("@MonthlyRate", lease.MonthlyRate);
                sqlCommand.Parameters.AddWithValue("@Description", lease.Description);
                sqlCommand.Parameters.AddWithValue("@DateLeaseStarts", lease.DateLeaseStarts);
                sqlCommand.Parameters.AddWithValue("@DateLeaseEnds", lease.DateLeaseEnds);
                sqlCommand.Parameters.AddWithValue("@Notes", lease.Notes);
                sqlCommand.Parameters.AddWithValue("StatusTypeID", lease.StatusTypeID);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error updating lease.", ex);
        }
    }

    public static void insertLease(Lease lease)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spLeaseInsert", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@PropertyID", lease.PropertyID);
                sqlCommand.Parameters.AddWithValue("@TenantID", lease.TenantID);
                sqlCommand.Parameters.AddWithValue("@DateLeaseStarts", lease.DateLeaseStarts);
                sqlCommand.Parameters.AddWithValue("@DateLeaseEnds", lease.DateLeaseEnds);
                sqlCommand.Parameters.AddWithValue("@Description", lease.Description);
                sqlCommand.Parameters.AddWithValue("@MonthlyRate", lease.MonthlyRate);
                sqlCommand.Parameters.AddWithValue("@Notes", lease.Notes);
                sqlCommand.Parameters.AddWithValue("@StatusTypeID", lease.StatusTypeID);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters["@ID"].Value = lease.Id;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int leaseID = (int)sqlCommand.Parameters["@ID"].Value;
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error inserting lease.", ex);
        }
    }
}