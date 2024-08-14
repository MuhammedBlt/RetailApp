namespace RetailApp.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }    
    public string ProductDescription { get; set; } 
    public decimal ProductPrice { get; set; } 

    public Category category { get; set; }

    public int Stock { get; set; }
  

  
}
