namespace RetailApp.Entities;

public class Order
{
public int orderId { get; set; }
public DateTime orderDate { get; set; }
public int orderCost { get; set; }
public int orderQuantity { get; set; }

public Customer customer { get; set; }



}
