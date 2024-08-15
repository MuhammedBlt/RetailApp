using System.ComponentModel.DataAnnotations.Schema;

namespace RetailApp.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }=string.Empty;   
    public string ProductDescription { get; set; } = string.Empty;
    public decimal ProductPrice { get; set; } 
    [Column (TypeName = "decimal (18,2)")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }

    public int Stock { get; set; }
  

  
}
