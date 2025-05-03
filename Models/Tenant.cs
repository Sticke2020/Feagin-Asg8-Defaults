using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg10_SQL
{
    public class Tenant : SlumLordRentalBase, ITenant
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip {  get; set; }
        


        // ToString() method so that the listBox displays the information properly
        public override string ToString()
        {
            // The $ is for interpolation
            return $"ID: {Id} {FirstName} {LastName} {City}, {Zip} ({getStatusTypeDescription()}) ";

            // Can also be written
            // return " ID: " + ID.ToString() + " " + FirstName etc
        }
    }
}
