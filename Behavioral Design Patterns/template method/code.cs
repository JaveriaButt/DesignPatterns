using System;

abstract class BeverageMaker
{
    // Template method
    public void MakeBeverage()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    private void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();
}

class TeaMaker : BeverageMaker
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}

class CoffeeMaker : BeverageMaker
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}

class Program
{
    static void Main()
    {
        BeverageMaker teaMaker = new TeaMaker();
        teaMaker.MakeBeverage();

        BeverageMaker coffeeMaker = new CoffeeMaker();
        coffeeMaker.MakeBeverage();
    }
}
