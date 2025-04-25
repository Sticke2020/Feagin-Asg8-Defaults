using System;

    public class SlumLordRentalBase   // This is a Base class, not an interface, notice it has a the method getDateTimeString that has code.
    {
    

        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime  DateUpdated { get; set; }
        public byte StatusTypeID { get; set; }  // A byte is 8 bits, values 0 = 255  which is a tinyint in SQL Server, 1=Active, 2=Deleted
        public int AddedByID { get; set; }  // the ID of the employee who added the record

        public String getDateTimeString(DateTime dateTime)
        {
            // Get the String time from a DateTime object
            // Format:  01/01/2022 10:22 am
            return dateTime.ToString("MM/dd/yyyy h:mm tt");
        }

        public string getStatusTypeDescription()
        {
            String description = "Unknown";

            if (StatusTypeID == 1)
                description = "Active";
            else if (StatusTypeID == 2)
                description = "Deleted";


            return description;
        }
    }

