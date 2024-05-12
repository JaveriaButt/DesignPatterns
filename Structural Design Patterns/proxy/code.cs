using System;

// Step 2: Define Subject Interface
interface IImage
{
    void Display();
}

// Step 3: Implement Real Subject
class RealImage : IImage
{
    private string _filename;

    public RealImage(string filename)
    {
        _filename = filename;
        LoadImageFromDisk();
    }

    private void LoadImageFromDisk()
    {
        Console.WriteLine("Loading image: " + _filename);
    }

    public void Display()
    {
        Console.WriteLine("Displaying image: " + _filename);
    }
}

// Step 4: Implement Proxy
class ProxyImage : IImage
{
    private RealImage _realImage;
    private string _filename;

    public ProxyImage(string filename)
    {
        _filename = filename;
    }

    public void Display()
    {
        if (_realImage == null)
        {
            _realImage = new RealImage(_filename);
        }
        _realImage.Display();
    }
}

// Step 5: Client Code
class Client
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("example.jpg");

        // Image will be loaded from disk only when Display() is called
        image.Display();

        // Image will not be loaded again, as it has been cached in the Proxy
        image.Display();
    }
}
