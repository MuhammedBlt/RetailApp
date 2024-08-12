namespace RetailApp.Entities;

public class Product
{
    public int ProductId { get; set; } // Primary key
    public string Name { get; set; }    // Name of the product
    public string Description { get; set; } // Description of the product
    public decimal Price { get; set; } // Price of the product
    public string Category { get; set; } // Category of the product (e.g., shirts, pants)
    public int StockQuantity { get; set; } // Quantity in stock
  
}
