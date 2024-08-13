namespace RetailApp.Entities;

public class Customer:User
{ 
    public int cutomerId { get; set; }
    public string customerName { get; set; }
    public int customerAddress { get; set; }


}
