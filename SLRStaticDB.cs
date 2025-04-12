using System;
using System.Collections.Generic;

namespace Feagin_Asg8_Defaults  // Don't forget to change the namespace
{
    internal static class SLRStaticDB
    {
      // This class is used to simulate Slum Lord Rentals Database Tables


        private static int ObjectCount = 0; // Used to Auto Increment the ID

       
        // listTenant is a list of Tenant objects, We will Default with 2 records.
        private static List<Tenant> listTenant = new List<Tenant>()
        {
            new Tenant
            {
                 ID =++ObjectCount, FirstName = "Andy", 
                 LastName = "Bangsberg", City = "Cumberland",  Zip = "54829",
                 DateAdded = DateTime.Now    
            },

            new Tenant 
            {
                ID =++ObjectCount, FirstName = "Rene", 
                LastName = "Bylander", City = "Menomonie", Zip ="54751",
                DateAdded = DateTime.Now
            },

            new Tenant
            {
                ID =++ObjectCount, FirstName = "Matt",
                LastName = "Feagin", City = "NewRichmond", Zip ="54017",
                DateAdded = DateTime.Now
            },
        };

        // Method to GET all the Tenant Records
        public static List<Tenant> getTenants()
        {
            return listTenant;
        }


        // Method to Insert a Tenant Record
        public static void addTenant(Tenant tenant)
        {   
            tenant.ID = ++ObjectCount;
            listTenant.Add(tenant);
        }


        // Method to update a Tenant Record
        public static void updateTenant(Tenant tenant)
        {
            // Find the existing tenant, then replace it. LINQ notation
            int existingIndex = listTenant.FindIndex(t => t.ID == tenant.ID);

            if (existingIndex != -1)
            {
                tenant.DateUpdated = DateTime.Now;
                listTenant[existingIndex] = tenant;  // Replace the tenant object
            }
        }

    }
}
