using System;
using System.Collections;

public interface IIterator
{
    bool HasNext();
    object Next();
}

public interface IIterable
{
    IIterator GetIterator();
}

public class ProductIterator : IIterator
{
    private readonly string[] _products;
    private int _position = 0;

    public ProductIterator(string[] products)
    {
        _products = products;
    }

    public bool HasNext()
    {
        return _position < _products.Length;
    }

    public object Next()
    {
        if (!HasNext())
        {
            return null;
        }
        return _products[_position++];
    }
}

public class ProductCatalog : IIterable
{
    private readonly string[] _productCatalog;

    public ProductCatalog(string[] productCatalog)
    {
        _productCatalog = productCatalog;
    }

    public IIterator GetIterator()
    {
        return new ProductIterator(_productCatalog);
    }
}

public class IteratorPatternExample
{
    public static void Main(string[] args)
    {
        string[] products = { "Product 1", "Product 2", "Product 3" };
        ProductCatalog productCatalog = new ProductCatalog(products);

        IIterator iterator = productCatalog.GetIterator();
        while (iterator.HasNext())
        {
            string product = (string)iterator.Next();
            Console.WriteLine(product);
        }
    }
}
