using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Feagin_Asg10_SQL
{
    public class Lease : SlumLordRentalBase, ILease
    {
        public int PropertyID { get; set; }
        public int TenantID { get; set; }
        public String Description { get; set; }
        public DateTime DateLeaseStarts { get; set; }
        public DateTime DateLeaseEnds { get; set; }
        public decimal MonthlyRate { get; set; }
        public String Notes { get; set; }
        


        public override string ToString()
        {
            // The $ is for interpolation
            return $"ID: {Id} - {PropertyID} {TenantID} {DateLeaseStarts} {DateLeaseEnds} ({getStatusTypeDescription()}) ";

            // Can also be written
            // return " ID: " + ID.ToString() + " " + FirstName etc
        }
    }
}
