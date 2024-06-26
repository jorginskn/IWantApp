﻿namespace IWantApp.Domain.Products;

public class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }
    public bool hasStock { get; set; }
    public int CategoryId { get; set; }
}
