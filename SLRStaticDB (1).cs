using System;
using System.Collections.Generic;
using System.Linq;

namespace Feagin_Asg9_SLR  // Don't forget to change the namespace
{
    internal static class SLRStaticDB
    {
        // This class is used to simulate Slum Lord Rentals Database Tables

        // ObjectCount is to simulate AutoIncrementing Id.
        private static int tenantObjectCount = 0; 
        private static int propertyObjectCount = 0; 
        private static int leaseObjectCount = 0;


        // listTenant is a list of Tenant objects, We will Default with 2 records.
        private static List<Tenant> listTenant = new List<Tenant>()
        {
            new Tenant
            {
                 Id =++tenantObjectCount, FirstName = "Andy",
                 LastName = "Bangsberg", City = "Cumberland",  Zip = "54829",
                 DateAdded = DateTime.Now,
                 Address = "1313 Mockingbird Lane",
                 State = "WI"
            },

            new Tenant 
            {
                Id =++tenantObjectCount, FirstName = "Rene", 
                LastName = "Bylander", City = "Menomonie", Zip ="54751",
                DateAdded = DateTime.Now
            },
        };


        // listTenant is a list of Tenant objects, We will Default with 2 records.
        private static List<Property> listProperty = new List<Property>()
        {
            new Property
            {
                 Id =++propertyObjectCount, Address = "123 Main Street",
                 City = "Cumberland", State = "WI",  Zip = "54829",
                 DateAdded = DateTime.Now
            },

            new Property
            {
                 Id =++propertyObjectCount, Address = "1313 Mocking Bird Lane",
                 City = "HollyWood", State = "CA",  Zip = "90024",
                 DateAdded = DateTime.Now
            },
        };


        // TODO:   Create the list for Leases, and give it two records

        //  *******  Tenant Methods ******************************//

        // Method to GET all the Tenant Records
        public static List<Tenant> getTenants()
        {
            return listTenant;
        }

        // Method to Insert a Tenant Record
        public static void addTenant(Tenant tenant)
        {   
            tenant.Id = ++tenantObjectCount;
            listTenant.Add(tenant);
        }

        // Method to update a Tenant Record
        public static void updateTenant(Tenant tenant)
        {
            // Find the existing tenant, then replace it. LINQ notation
            int existingIndex = listTenant.FindIndex(t => t.Id == tenant.Id);

            if (existingIndex != -1)
            {
                tenant.DateUpdated = DateTime.Now;
                listTenant[existingIndex] = tenant;  // Replace the tenant object
            }

        }
        public static Tenant getTenantByID(int id)
        {
            Tenant tenant;

            tenant = listTenant.FirstOrDefault(t => t.Id == id);
         
            return tenant;
        }
        //  *******  Property Methods ******************************//

        public static List<Property> getProperties()
        {
            return listProperty;
        }

        // Method to Insert a Tenant Record
        public static void addProperty(Property property)
        {
            property.Id = ++tenantObjectCount;
            listProperty.Add(property);
        }

        // Method to update a Tenant Record
        public static void updateTenant(Property property)
        {
            // Find the existing tenant, then replace it. LINQ notation
            int existingIndex = listTenant.FindIndex(t => t.Id == property.Id);

            if (existingIndex != -1)
            {
                property.DateUpdated = DateTime.Now;
                listProperty[existingIndex] = property;  // Replace the tenant object
            }

        }

        public static Property getPropertyByID(int id)
        {
            Property property;

            property = listProperty.FirstOrDefault(p => p.Id == id);

            return property;
        }






        //  *******  Lease Methods ******************************//
        // TODO:  Add the three Lease Methods.


    }
}
