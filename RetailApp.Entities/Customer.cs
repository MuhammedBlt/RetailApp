namespace RetailApp.Entities;

public class Customer:User
{ 
    public new int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public int CustomerAddress { get; set; }


}
