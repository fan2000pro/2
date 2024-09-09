using System;
using System.Collections.Generic;

public abstract class Pro
{
    public abstract string Name { get; set; }
    public virtual decimal Price { get; set; }
    public abstract string GetInformation();
}
public class Toy : Pro
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public string AgeGroup { get; set; }
    public override string GetInformation()
    {
        return $"Toy: {Name}, Price: {Price:C}, Age Group: {AgeGroup}";
    }
}
public class Meat : Pro
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public DateTime ExpirationDate { get; set; }
    public override string GetInformation()
    {
        return $"Meat: {Name}, Price: {Price:C}, Expiration Date: {ExpirationDate:MM/dd/yyyy}";
    }
}
public class Drink : Pro
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public double Volume { get; set; }
    public override string GetInformation()
    {
        return $"Drink: {Name}, Price: {Price:C}, Volume: {Volume}L";
    }
}
public class Book : Pro
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public string Author { get; set; }
    public override string GetInformation()
    {
        return $"Book: {Name}, Price: {Price:C}, Author: {Author}";
    }
}
public class Electronics : Pro
{
    public override string Name { get; set; }
    public override decimal Price { get; set; }
    public int WarrantyPeriod { get; set; }
    public override string GetInformation()
    {
        return $"Electronics: {Name}, Price: {Price:C}, Warranty: {WarrantyPeriod} months";
    }
}
public class DisMan
{
    public static void ApplyDiscount(List<Pro> products, decimal discountPercentage)
    {
        foreach (var product in products)
        {
            product.Price -= product.Price * (discountPercentage / 100);
        }
    }
}
class Program
{
    static void Main()
    {
        var products = new List<Pro>
        {
            new Toy { Name = "ak-47", Price = 49.99m, AgeGroup = "546-1012" },
            new Meat { Name = "Steak", Price = 12.99m, ExpirationDate = DateTime.Now.AddDays(7) },
            new Drink { Name = "Orange Juice", Price = 3.49m, Volume = 1.5 },
            new Book { Name = "My-My", Price = 29.99m, Author = "John Doe" },
            new Electronics { Name = "Samsung", Price = 8000.99m, WarrantyPeriod = 240 }
        };
        DisMan.ApplyDiscount(products, 10);
        foreach (var product in products)
        {
            Console.WriteLine(product.GetInformation());
        }
    }
}
