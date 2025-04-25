using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg9_SLR
{
    public class Property : SlumLordRentalBase, IProperty
    {
        public String Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public decimal Price { get; set; }
        public string DescriptionBrief { get; set; }
        public string DescriptionFull { get; set; }
        public int Bathrooms { get; set; }
        public int Bedrooms { get; set; }
        public bool OnsiteParking { get; set; }
        public bool OnsiteLaundry { get; set; }
        public DateTime AvailableOn { get; set; } // Available ON


        public override string ToString()
        {
            // The $ is for interpolation
            return $"ID: {Id} - {Address} {City} {State} ";

            // Can also be written
            // return " ID: " + ID.ToString() + " " + FirstName etc
        }
    }
}
