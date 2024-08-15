namespace RetailApp.Entities;

public class Order
{
public int OrderId { get; set; }
public DateTime OrderDate { get; set; } = DateTime.Now;
public int  OrderCost { get; set; }
public int OrderQuantity { get; set; }
public int? CustomerId { get; set; }
public Customer? Customer { get; set; }




}
