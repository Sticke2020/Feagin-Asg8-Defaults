using System;

public interface ITenant
 {
    // PROPERTIES that you will need in your Tenant class
    String FirstName { get; set; }
    String LastName { get; set; }
    String Address { get; set; }
    String City { get; set; }
    String State { get; set; }
    String Zip { get; set; }
    String Phone { get; set; }
    String Email { get; set; }
}