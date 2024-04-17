using System;

// Abstract Product: Screen
public interface IScreen
{
    void Display();
}

// Concrete Products: SmallScreen and LargeScreen
public class SmallScreen : IScreen
{
    public void Display()
    {
        Console.WriteLine("Displaying on a small screen...");
    }
}

public class LargeScreen : IScreen
{
    public void Display()
    {
        Console.WriteLine("Displaying on a large screen...");
    }
}

// Abstract Product: Processor
public interface IProcessor
{
    void Process();
}

// Concrete Products: SmallProcessor and LargeProcessor
public class SmallProcessor : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Processing on a small processor...");
    }
}

public class LargeProcessor : IProcessor
{
    public void Process()
    {
        Console.WriteLine("Processing on a large processor...");
    }
}

// Abstract Factory: DeviceFactory
public interface IDeviceFactory
{
    IScreen CreateScreen();
    IProcessor CreateProcessor();
}

// Concrete Factories: SmartwatchFactory, SmartphoneFactory, TabletFactory
public class SmartwatchFactory : IDeviceFactory
{
    public IScreen CreateScreen()
    {
        return new SmallScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new SmallProcessor();
    }
}

public class SmartphoneFactory : IDeviceFactory
{
    public IScreen CreateScreen()
    {
        return new LargeScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new LargeProcessor();
    }
}

public class TabletFactory : IDeviceFactory
{
    public IScreen CreateScreen()
    {
        return new LargeScreen();
    }

    public IProcessor CreateProcessor()
    {
        return new LargeProcessor();
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        // Creating a smartwatch using SmartwatchFactory
        IDeviceFactory smartwatchFactory = new SmartwatchFactory();
        IScreen smartwatchScreen = smartwatchFactory.CreateScreen();
        IProcessor smartwatchProcessor = smartwatchFactory.CreateProcessor();

        Console.WriteLine("Creating a smartwatch:");
        smartwatchScreen.Display();
        smartwatchProcessor.Process();

        // Creating a smartphone using SmartphoneFactory
        IDeviceFactory smartphoneFactory = new SmartphoneFactory();
        IScreen smartphoneScreen = smartphoneFactory.CreateScreen();
        IProcessor smartphoneProcessor = smartphoneFactory.CreateProcessor();

        Console.WriteLine("\nCreating a smartphone:");
        smartphoneScreen.Display();
        smartphoneProcessor.Process();
    }
}
