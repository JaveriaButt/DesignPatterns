using System;

// Step 1: Define the Coffee Interface
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Step 2: Implement the Base Coffee Class
public class PlainCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Plain Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}

// Step 3: Create the Coffee Decorator Abstract Class
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee decoratedCoffee;

    public CoffeeDecorator(ICoffee decoratedCoffee)
    {
        this.decoratedCoffee = decoratedCoffee;
    }

    public virtual string GetDescription()
    {
        return decoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return decoratedCoffee.GetCost();
    }
}

// Step 4: Implement Concrete Coffee Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

    public override string GetDescription()
    {
        return decoratedCoffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return decoratedCoffee.GetCost() + 0.5;
    }
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee) { }

    public override string GetDescription()
    {
        return decoratedCoffee.GetDescription() + ", Sugar";
    }

    public override double GetCost()
    {
        return decoratedCoffee.GetCost() + 0.2;
    }
}

// Step 5: Client Code
class Program
{
    static void Main(string[] args)
    {
        // Plain Coffee
        ICoffee coffee = new PlainCoffee();
        Console.WriteLine("Description: " + coffee.GetDescription());
        Console.WriteLine("Cost: $" + coffee.GetCost());

        // Coffee with Milk
        ICoffee milkCoffee = new MilkDecorator(new PlainCoffee());
        Console.WriteLine("\nDescription: " + milkCoffee.GetDescription());
        Console.WriteLine("Cost: $" + milkCoffee.GetCost());

        // Coffee with Sugar and Milk
        ICoffee sugarMilkCoffee = new SugarDecorator(new MilkDecorator(new PlainCoffee()));
        Console.WriteLine("\nDescription: " + sugarMilkCoffee.GetDescription());
        Console.WriteLine("Cost: $" + sugarMilkCoffee.GetCost());
    }
}
