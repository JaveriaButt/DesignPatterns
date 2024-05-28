using System;
using System.Collections.Generic;

interface ShoppingCartVisitor
{
    int Visit(Book book);
    int Visit(Fruit fruit);
}

class ShoppingCartVisitorImpl : ShoppingCartVisitor
{
    public int Visit(Book book)
    {
        int cost = book.GetPrice();
        Console.WriteLine($"Book ISBN: {book.GetIsbnNumber()} cost = {cost}");
        return cost;
    }

    public int Visit(Fruit fruit)
    {
        int cost = fruit.GetPricePerKg() * fruit.GetWeight();
        Console.WriteLine($"{fruit.GetName()} cost = {cost}");
        return cost;
    }
}

interface ItemElement
{
    int Accept(ShoppingCartVisitor visitor);
}

class Book : ItemElement
{
    private int price;
    private string isbnNumber;

    public Book(int price, string isbnNumber)
    {
        this.price = price;
        this.isbnNumber = isbnNumber;
    }

    public int GetPrice() => price;
    public string GetIsbnNumber() => isbnNumber;

    public int Accept(ShoppingCartVisitor visitor)
    {
        return visitor.Visit(this);
    }
}

class Fruit : ItemElement
{
    private int pricePerKg;
    private int weight;
    private string name;

    public Fruit(int pricePerKg, int weight, string name)
    {
        this.pricePerKg = pricePerKg;
        this.weight = weight;
        this.name = name;
    }

    public int GetPricePerKg() => pricePerKg;
    public int GetWeight() => weight;
    public string GetName() => name;

    public int Accept(ShoppingCartVisitor visitor)
    {
        return visitor.Visit(this);
    }
}

class Program
{
    static int CalculatePrice(List<ItemElement> items)
    {
        ShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
        int sum = 0;
        foreach (var item in items)
        {
            sum += item.Accept(visitor);
        }
        return sum;
    }

    static void Main()
    {
        List<ItemElement> items = new List<ItemElement>
        {
            new Book(20, "1234"),
            new Book(100, "5678"),
            new Fruit(10, 2, "Banana"),
            new Fruit(5, 5, "Apple")
        };

        int total = CalculatePrice(items);
        Console.WriteLine($"Total cost = {total}");
    }
}
