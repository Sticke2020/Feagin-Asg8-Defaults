using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feagin_Asg8_Defaults
{
    public class Tenant : ITenant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip {  get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }


        // ToString() method so that the listBox displays the information properly
        public override string ToString()
        {
            // The $ is for interpolation
            return $"ID: {ID} {FirstName} {LastName} {City}, {Zip} ";

            // Can also be written
            // return " ID: " + ID.ToString() + " " + FirstName etc
        }
    }
}
