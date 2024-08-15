﻿namespace RetailApp.Entities;

public class ShopCart
{
public int ShopCartId { get; set; }
public int? ProductId { get; set; }
public Product? Product { get;}
public int? CustomerId { get; set; }
public Customer? Customer { get; set; }

public int? OrderId { get; set; }

public  Order? Order { get; set; }
}
