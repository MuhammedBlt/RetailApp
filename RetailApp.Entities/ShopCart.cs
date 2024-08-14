namespace RetailApp.Entities;

public class ShopCart
{
public int ShopCartId { get; set; }
public Product product { get;}
public Customer customer { get; set; }

public  Order order { get; set; }
}
