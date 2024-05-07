using System;
using System.Collections.Generic;

// Base class for all employees
class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }
}

// Concrete employee classes
class Worker : Employee
{
    public string Position { get; set; }

    public Worker(string name, string position) : base(name)
    {
        Position = position;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Worker: Name - {Name}, Position - {Position}");
    }
}

class Manager : Employee
{
    public string Department { get; set; }

    public Manager(string name, string department) : base(name)
    {
        Department = department;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Manager: Name - {Name}, Department - {Department}");
    }
}

class Executive : Employee
{
    public string Role { get; set; }

    public Executive(string name, string role) : base(name)
    {
        Role = role;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Executive: Name - {Name}, Role - {Role}");
    }
}

// Class to manage the company directory
class CompanyDirectory
{
    private List<Employee> _employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        _employees.Remove(employee);
    }

    public void DisplayDetails()
    {
        foreach (var employee in _employees)
        {
            if (employee is Worker)
            {
                ((Worker)employee).DisplayDetails();
            }
            else if (employee is Manager)
            {
                ((Manager)employee).DisplayDetails();
            }
            else if (employee is Executive)
            {
                ((Executive)employee).DisplayDetails();
            }
        }
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        CompanyDirectory directory = new CompanyDirectory();

        Worker worker = new Worker("John", "Developer");
        Manager manager = new Manager("Bob", "HR");
        Executive executive = new Executive("Smith", "CEO");

        directory.AddEmployee(worker);
        directory.AddEmployee(manager);
        directory.AddEmployee(executive);

        Console.WriteLine("Company Directory:");
        directory.DisplayDetails();
    }
}
