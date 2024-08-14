namespace RetailApp.Entities;

public class Order
{
public int OrderId { get; set; }
public DateTime OrderDate { get; set; }
public int  OrderCost { get; set; }
public int OrderQuantity { get; set; }

public Customer customer { get; set; }



}
