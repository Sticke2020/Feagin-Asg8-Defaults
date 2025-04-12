using System;

public interface ITenant
 {
    // PROPERTIES that you will need in your Tenant class
    string FirstName { get; set; }
    string LastName { get; set; }
    string Phone { get; set; }
    string Email { get; set; }
    string City { get; set; }
    string State { get; set; }
    string Zip { get; set; }
}