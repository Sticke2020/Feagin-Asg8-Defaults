
using Feagin_Asg10_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public static class TenantDB
{
    public static List<Tenant> getTenants(byte statusTypeID)
    {
        List<Tenant> listTenants = new List<Tenant>();
        String sqlSelect = "SELECT * FROM dbo.fnTenantListAsTable(@StatusTypeID, @APIKey) order by DateUpdated desc";

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
                    Tenant tenant = new Tenant
                    {
                        Id = (int)dataReader["ID"],
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        City = dataReader["City"].ToString(),
                        Zip = dataReader["Zip"].ToString(),
                        StatusTypeID = (byte)dataReader["StatusTypeID"],
                        DateAdded = (DateTime)dataReader["DateAdded"],
                        DateUpdated = (DateTime)dataReader["DateUpdated"]
                    };
                    listTenants.Add(tenant);
                }
            }
        }
        
       

        return listTenants;
    }

    public static Tenant getTenantByID(int id)
    {
        Tenant tenant = new Tenant();

        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spTenantSelect", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();

                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        tenant.Id = (int)dataReader["ID"];
                        tenant.FirstName = dataReader["FirstName"].ToString();
                        tenant.LastName = dataReader["LastName"].ToString();
                        tenant.Address = dataReader["Address"].ToString();
                        tenant.Email = dataReader["Email"].ToString();
                        tenant.Phone = dataReader["Phone"].ToString();
                        tenant.City = dataReader["City"].ToString();
                        tenant.State = dataReader["State"].ToString();
                        tenant.Zip = dataReader["Zip"].ToString();
                        tenant.StatusTypeID = (byte)dataReader["StatusTypeID"];
                        tenant.DateAdded = (DateTime)dataReader["DateAdded"];
                        tenant.DateUpdated = (DateTime)dataReader["DateUpdated"];
                        tenant.AddedByID = (int)dataReader["AddedByEmployeeID"];
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error retrieving tenant by ID.", ex);
        }

        return tenant;
    }

    public static void updateTenant(Tenant tenant)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spTenantUpdate", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID", tenant.Id);
                sqlCommand.Parameters.AddWithValue("@FirstName", tenant.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", tenant.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", tenant.Email);
                sqlCommand.Parameters.AddWithValue("@Phone", tenant.Phone);
                sqlCommand.Parameters.AddWithValue("@Address", tenant.Address);
                sqlCommand.Parameters.AddWithValue("@City", tenant.City);
                sqlCommand.Parameters.AddWithValue("@State", tenant.State);
                sqlCommand.Parameters.AddWithValue("@Zip", tenant.Zip);
                sqlCommand.Parameters.AddWithValue("StatusTypeID", tenant.StatusTypeID);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error updating tenant.", ex);
        }
    }

    public static void insertTenant(Tenant tenant)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spTenantInsert", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@FirstName", tenant.FirstName);
                sqlCommand.Parameters.AddWithValue("@LastName", tenant.LastName);
                sqlCommand.Parameters.AddWithValue("@Email", tenant.Email);
                sqlCommand.Parameters.AddWithValue("@Phone", tenant.Phone);
                sqlCommand.Parameters.AddWithValue("@Address", tenant.Address);
                sqlCommand.Parameters.AddWithValue("@City", tenant.City);
                sqlCommand.Parameters.AddWithValue("@State", tenant.State);
                sqlCommand.Parameters.AddWithValue("@Zip", tenant.Zip);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters["@ID"].Value = 0;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int tenantID = (int)sqlCommand.Parameters["@ID"].Value;
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error inserting tenant.", ex);
        }
    }
}
