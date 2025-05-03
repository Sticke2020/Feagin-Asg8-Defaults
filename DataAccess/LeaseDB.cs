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

        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spLeaseList", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
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
                            Description = dataReader["LeaseDescription"].ToString(),
                            StatusTypeID = (byte)dataReader["StatusTypeID"]
                        };
                        listLeases.Add(lease);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error retrieving leases.", ex);
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
}