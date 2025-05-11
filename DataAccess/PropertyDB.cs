using Feagin_Asg10_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class PropertyDB
{
    public static List<Property> getProperties(byte statusTypeID)
    {
        List<Property> listProperties = new List<Property>();
        String sqlSelect = "SELECT * FROM dbo.fnPropertyListAsTable(@StatusTypeID, @APIKey) order by DateUpdated desc";

        
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
                    Property property = new Property
                    {
                        Id = (int)dataReader["ID"],
                        City = dataReader["City"].ToString(),
                        State = dataReader["State"].ToString(),
                        Address = dataReader["Address"].ToString(),
                        DateUpdated = (DateTime)dataReader["DateUpdated"],
                        StatusTypeID = (byte)dataReader["StatusTypeID"]
                    };
                    listProperties.Add(property);
                }
            }
        }
       
        return listProperties;
    }

    public static Property getPropertyByID(int id)
    {
        Property property = new Property();

        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spPropertySelect", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@ID", id);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    if (dataReader.Read())
                    {
                        property.Id = (int)dataReader["ID"];
                        property.Address = dataReader["Address"].ToString();
                        property.City = dataReader["City"].ToString();
                        property.State = dataReader["State"].ToString();
                        property.Zip = dataReader["Zip"].ToString();
                        property.Price = (Decimal)dataReader["Price"];
                        property.DescriptionBrief = dataReader["DescriptionBrief"].ToString();
                        property.DescriptionFull = dataReader["DescriptionFull"].ToString();
                        property.Bedrooms = (byte)dataReader["Bedrooms"];
                        property.Bathrooms = (byte)dataReader["Bathrooms"];
                        property.OnsiteParking = (bool)dataReader["OnsiteParking"];
                        property.OnsiteLaundry = (bool)dataReader["OnsiteLaundry"];
                        property.AvailableOn = (DateTime)dataReader["DateAvailable"];
                        property.DateAdded = (DateTime)dataReader["DateAdded"];
                        property.DateUpdated = (DateTime)dataReader["DateUpdated"];
                        property.StatusTypeID = (byte)dataReader["StatusTypeID"];
                        property.AddedByID = (int)dataReader["AddedByEmployeeID"];
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error retrieving property by ID.", ex);
        }

        return property;
    }

    public static void insertProperty(Property property)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spPropertyInsert", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Address", property.Address);
                sqlCommand.Parameters.AddWithValue("@City", property.City);
                sqlCommand.Parameters.AddWithValue("@State", property.State);
                sqlCommand.Parameters.AddWithValue("@Zip", property.Zip);
                sqlCommand.Parameters.AddWithValue("@Price", property.Price);
                sqlCommand.Parameters.AddWithValue("@DescriptionBrief", property.DescriptionBrief);
                sqlCommand.Parameters.AddWithValue("@DescriptionFull", property.DescriptionFull);
                sqlCommand.Parameters.AddWithValue("@Bathrooms", property.Bathrooms);
                sqlCommand.Parameters.AddWithValue("@Bedrooms", property.Bedrooms);
                sqlCommand.Parameters.AddWithValue("@OnsiteParking", property.OnsiteParking);
                sqlCommand.Parameters.AddWithValue("@OnsiteLaundry", property.OnsiteLaundry);
                sqlCommand.Parameters.AddWithValue("@DateAvailable", property.AvailableOn);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters["@ID"].Value = property.Id;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();

                int propertyID = (int)sqlCommand.Parameters["@ID"].Value;
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error inserting property.", ex);
        }
    }

    public static void updateProperty(Property property)
    {
        try
        {
            using (SqlConnection sqlConnection = new SqlConnection(DatabaseSettings.ConnectionString))
            using (SqlCommand sqlCommand = new SqlCommand("spPropertyUpdate", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@ID", property.Id);
                sqlCommand.Parameters.AddWithValue("@Price", property.Price);
                sqlCommand.Parameters.AddWithValue("@DescriptionBrief", property.DescriptionBrief);
                sqlCommand.Parameters.AddWithValue("@DescriptionFull", property.DescriptionFull);
                sqlCommand.Parameters.AddWithValue("@Bathrooms", property.Bathrooms);
                sqlCommand.Parameters.AddWithValue("@Bedrooms", property.Bedrooms);
                sqlCommand.Parameters.AddWithValue("@OnsiteParking", property.OnsiteParking);
                sqlCommand.Parameters.AddWithValue("@OnsiteLaundry", property.OnsiteLaundry);
                sqlCommand.Parameters.AddWithValue("@Address", property.Address);
                sqlCommand.Parameters.AddWithValue("@City", property.City);
                sqlCommand.Parameters.AddWithValue("@State", property.State);
                sqlCommand.Parameters.AddWithValue("@Zip", property.Zip);
                sqlCommand.Parameters.AddWithValue("@DateAvailable", property.AvailableOn);
                sqlCommand.Parameters.AddWithValue("StatusTypeID", property.StatusTypeID);
                sqlCommand.Parameters.AddWithValue("@APIKey", DatabaseSettings.ApiKey);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Error updating property.", ex);
        }
    }
}