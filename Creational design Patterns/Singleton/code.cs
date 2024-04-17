using System;

public class Printer
{
    private static Printer printer;
    private string name;
    private int counter;

    private Printer(string name)
    {
        this.name = name;
        counter = 0;
    }

    public static Printer GetInstance()
    {
        lock (typeof(Printer))
        {
            if (printer == null)
            {
                printer = new Printer("Default Printer");
            }
        }
        return printer;
    }

    public void PrintDocument(string document)
    {
        counter++;
        Console.WriteLine(counter + ": " + name + " is printing: " + document);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Printer p1 = Printer.GetInstance();
        Printer p2 = Printer.GetInstance();
        p1.PrintDocument("Document 1");
        p2.PrintDocument("Document 2");
    }
}
