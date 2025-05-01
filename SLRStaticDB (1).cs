using System;
using System.Collections.Generic;
using System.Linq;

namespace Feagin_Asg10_SQL  // Don't forget to change the namespace
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
                 State = "WI", StatusTypeID = 1
            },

            new Tenant 
            {
                Id =++tenantObjectCount, FirstName = "Rene", 
                LastName = "Bylander", City = "Menomonie", Zip ="54751",
                DateAdded = DateTime.Now, StatusTypeID = 1
            },
        };


        // listProperty is a list of Property objects, We will Default with 2 records.
        private static List<Property> listProperty = new List<Property>()
        {
            new Property
            {
                 Id =++propertyObjectCount, Address = "123 Main Street",
                 City = "Cumberland", State = "WI",  Zip = "54829",
                 DateAdded = DateTime.Now, AvailableOn = DateTime.Now, StatusTypeID = 1
            },

            new Property
            {
                 Id =++propertyObjectCount, Address = "1313 Mocking Bird Lane",
                 City = "HollyWood", State = "CA",  Zip = "90024",
                 DateAdded = DateTime.Now, AvailableOn = DateTime.Now, StatusTypeID = 1
            },
        };


        // TODO:   Create the list for Leases, and give it two records
        // listProperty is a list of Property objects, We will Default with 2 records.
        private static List<Lease> listLease = new List<Lease>()
        {
            new Lease
            {
                 Id =++leaseObjectCount, PropertyID = 1,
                 TenantID = 2, Description = "6 Month Lease No security deposite.",  MonthlyRate = 1500, Notes = "Pets are allowed ",
                 DateLeaseStarts = new DateTime(2025, 5, 15, 12, 0, 0),
                 DateLeaseEnds = new DateTime(2025, 11, 15, 12, 0, 0), StatusTypeID = 1
            },

            new Lease
            {
                 Id =++leaseObjectCount, PropertyID = 2,
                 TenantID = 1, Description = "1 Year Lease No security deposite",  MonthlyRate = 1600, Notes = "Pets are allowed ",
                 DateLeaseStarts = new DateTime(2025, 5, 01, 12, 0, 0),
                 DateLeaseEnds = new DateTime(2026, 5, 01, 12, 0, 0), StatusTypeID = 1
            },
        };

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

        // Method to Insert a Property Record
        public static void addProperty(Property property)
        {
            property.Id = ++propertyObjectCount;
            listProperty.Add(property);
        }

        // Method to update a Property Record
        public static void updateProperty(Property property)
        {
            // Find the existing tenant, then replace it. LINQ notation
            int existingIndex = listProperty.FindIndex(t => t.Id == property.Id);

            if (existingIndex != -1)
            {
                property.DateUpdated = DateTime.Now;
                listProperty[existingIndex] = property;  // Replace the property object
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
        // Method to GET all the Lease Records
        public static List<Lease> getLease()
        {
            return listLease;
        }

        // Method to Insert a Lease Record
        public static void addLease(Lease lease)
        {
            lease.Id = ++leaseObjectCount;
            listLease.Add(lease);
        }

        // Method to update a Tenant Record
        public static void updateLease(Lease lease)
        {
            // Find the existing Lease, then replace it. LINQ notation
            int existingIndex = listLease.FindIndex(l => l.Id == lease.Id);

            if (existingIndex != -1)
            {
                lease.DateUpdated = DateTime.Now;
                listLease[existingIndex] = lease;  // Replace the leasse object
            }

        }
        public static Lease getLeaseByID(int id)
        {
            Lease lease;

            lease = listLease.FirstOrDefault(l => l.Id == id);

            return lease;
        }
    }
}
