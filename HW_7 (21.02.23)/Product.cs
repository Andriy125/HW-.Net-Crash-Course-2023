using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


struct Product
{
    public string Name { get; set; }
    readonly DateTime ManufactureDate;
    public CategoryType Category { get; set; }
    public decimal Price { get; set; }
    public Product(string name, DateTime manufactureDate, CategoryType category, decimal price)
    {
        Name = name;
        ManufactureDate = manufactureDate;
        Category = category;
        Price = price;
    }
    public override string ToString()
    {
        return $"Product: {Name}, Manufacture Date: {ManufactureDate}, Category: {Category}, Price: {Price}";
    }
}

public enum CategoryType
{
    Food,
    Electronics,
    Clothing,
    Beauty,
    Home
}