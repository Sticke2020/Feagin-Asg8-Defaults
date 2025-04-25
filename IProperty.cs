using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    interface IProperty
    {
  
        String Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        decimal Price { get; set; }
        string DescriptionBrief { get; set; }
        string DescriptionFull { get; set; }
        int Bathrooms { get; set; }
        int Bedrooms { get; set; }
        bool OnsiteParking { get; set; }
        bool OnsiteLaundry { get; set; }
        DateTime AvailableOn { get; set; } // Available ON
    }

