namespace RetailApp.Entities;

public class Customer:User
{ 
    public  int CustomerId { get; set; }
    public string CustomerName { get; set; }=string.Empty;
    public int CustomerAddress { get; set; }
    public List<Order>Orders { get; set; } = new List<Order>();   


}
