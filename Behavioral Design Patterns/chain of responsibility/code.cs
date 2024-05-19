using System;

// Abstract handler class
public abstract class SupportHandler
{
    protected SupportHandler nextHandler;

    public void SetNextHandler(SupportHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(int level);
}

// Concrete handler class for Level 1 support
public class Level1SupportHandler : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level <= 1)
        {
            Console.WriteLine("Level 1 Support: Request handled");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Level 1 Support: Request escalated to Level 2");
            nextHandler.HandleRequest(level);
        }
        else
        {
            Console.WriteLine("No handler available for this request");
        }
    }
}

// Concrete handler class for Level 2 support
public class Level2SupportHandler : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level <= 2)
        {
            Console.WriteLine("Level 2 Support: Request handled");
        }
        else if (nextHandler != null)
        {
            Console.WriteLine("Level 2 Support: Request escalated to Level 3");
            nextHandler.HandleRequest(level);
        }
        else
        {
            Console.WriteLine("No handler available for this request");
        }
    }
}

// Concrete handler class for Level 3 support
public class Level3SupportHandler : SupportHandler
{
    public override void HandleRequest(int level)
    {
        if (level <= 3)
        {
            Console.WriteLine("Level 3 Support: Request handled");
        }
        else
        {
            Console.WriteLine("No handler available for this request");
        }
    }
}

// Client code
class Program
{
    static void Main(string[] args)
    {
        SupportHandler level1Handler = new Level1SupportHandler();
        SupportHandler level2Handler = new Level2SupportHandler();
        SupportHandler level3Handler = new Level3SupportHandler();

        level1Handler.SetNextHandler(level2Handler);
        level2Handler.SetNextHandler(level3Handler);

        // Simulating customer requests
        Console.WriteLine("Customer issue: Level 1");
        level1Handler.HandleRequest(1);

        Console.WriteLine("\nCustomer issue: Level 2");
        level1Handler.HandleRequest(2);

        Console.WriteLine("\nCustomer issue: Level 3");
        level1Handler.HandleRequest(3);

        Console.WriteLine("\nCustomer issue: Level 4");
        level1Handler.HandleRequest(4);
    }
}
