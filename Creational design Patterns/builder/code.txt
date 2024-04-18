using System;

// Product
class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public int RAM { get; set; }
    public int Storage { get; set; }

    public void Display()
    {
        Console.WriteLine($"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}GB, Storage: {Storage}GB");
    }
}

// Builder
interface IComputerBuilder
{
    void SetCPU(string cpu);
    void SetGPU(string gpu);
    void SetRAM(int ram);
    void SetStorage(int storage);
    Computer GetComputer();
}

// Concrete Builder
class GamingComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU(string cpu)
    {
        computer.CPU = cpu;
    }

    public void SetGPU(string gpu)
    {
        computer.GPU = gpu;
    }

    public void SetRAM(int ram)
    {
        computer.RAM = ram;
    }

    public void SetStorage(int storage)
    {
        computer.Storage = storage;
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

// Director
class ComputerDirector
{
    public void ConstructGamingComputer(IComputerBuilder builder)
    {
        builder.SetCPU("Intel Core i9");
        builder.SetGPU("NVIDIA GeForce RTX 3080");
        builder.SetRAM(32);
        builder.SetStorage(2000);
    }
}

// Client
class Program
{
    static void Main(string[] args)
    {
        ComputerDirector director = new ComputerDirector();
        IComputerBuilder builder = new GamingComputerBuilder();

        director.ConstructGamingComputer(builder);
        Computer gamingComputer = builder.GetComputer();

        Console.WriteLine("Constructed Gaming Computer:");
        gamingComputer.Display();
    }
}
