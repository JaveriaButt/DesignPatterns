using System;
using System.Collections.Generic;

// Command Interface
public interface ICommand
{
    void Execute();
}

// Receiver Class
public class Document
{
    public string Name { get; set; }

    public Document(string name)
    {
        Name = name;
    }

    public void Open()
    {
        Console.WriteLine($"Document '{Name}' opened.");
    }

    public void Close()
    {
        Console.WriteLine($"Document '{Name}' closed.");
    }

    public void Cut()
    {
        Console.WriteLine($"Document '{Name}' cut.");
    }

    public void Copy()
    {
        Console.WriteLine($"Document '{Name}' copied.");
    }

    public void Paste()
    {
        Console.WriteLine($"Document '{Name}' pasted.");
    }
}

// Concrete Command Classes
public class OpenCommand : ICommand
{
    private readonly Document _document;

    public OpenCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Open();
    }
}

public class CloseCommand : ICommand
{
    private readonly Document _document;

    public CloseCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Close();
    }
}

public class CutCommand : ICommand
{
    private readonly Document _document;

    public CutCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Cut();
    }
}

public class CopyCommand : ICommand
{
    private readonly Document _document;

    public CopyCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Copy();
    }
}

public class PasteCommand : ICommand
{
    private readonly Document _document;

    public PasteCommand(Document document)
    {
        _document = document;
    }

    public void Execute()
    {
        _document.Paste();
    }
}

// Invoker Class
public class Menu
{
    private readonly Dictionary<string, ICommand> _commands = new Dictionary<string, ICommand>();

    public void AddCommand(string operation, ICommand command)
    {
        _commands[operation] = command;
    }

    public void Click(string operation)
    {
        if (_commands.ContainsKey(operation))
        {
            _commands[operation].Execute();
        }
        else
        {
            Console.WriteLine($"No command found for {operation}");
        }
    }
}

// Client Code
public class Program
{
    public static void Main(string[] args)
    {
        // Create receiver
        Document document = new Document("MyDocument");

        // Create commands
        ICommand openCommand = new OpenCommand(document);
        ICommand closeCommand = new CloseCommand(document);
        ICommand cutCommand = new CutCommand(document);
        ICommand copyCommand = new CopyCommand(document);
        ICommand pasteCommand = new PasteCommand(document);

        // Create invoker
        Menu menu = new Menu();
        menu.AddCommand("Open", openCommand);
        menu.AddCommand("Close", closeCommand);
        menu.AddCommand("Cut", cutCommand);
        menu.AddCommand("Copy", copyCommand);
        menu.AddCommand("Paste", pasteCommand);

        // Simulate menu clicks
        menu.Click("Open");
        menu.Click("Copy");
        menu.Click("Paste");
        menu.Click("Close");
        menu.Click("Cut"); // Simulate an invalid command
    }
}
