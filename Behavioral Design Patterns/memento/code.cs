using System;
using System.Collections.Generic;

public class Document
{
    private string content;

    public Document(string content)
    {
        this.content = content;
    }

    public void Write(string text)
    {
        this.content += text;
    }

    public string GetContent()
    {
        return this.content;
    }

    public DocumentMemento CreateMemento()
    {
        return new DocumentMemento(this.content);
    }

    public void RestoreFromMemento(DocumentMemento memento)
    {
        this.content = memento.GetSavedContent();
    }
}

public class DocumentMemento
{
    private readonly string content;

    public DocumentMemento(string content)
    {
        this.content = content;
    }

    public string GetSavedContent()
    {
        return this.content;
    }
}

public class Caretaker
{
    private readonly Stack<DocumentMemento> mementos = new Stack<DocumentMemento>();

    public void SaveState(Document doc)
    {
        mementos.Push(doc.CreateMemento());
    }

    public void Undo(Document doc)
    {
        if (mementos.Count > 0)
        {
            doc.RestoreFromMemento(mementos.Pop());
        }
        else
        {
            Console.WriteLine("No mementos to restore");
        }
    }
}

public class MementoPatternExample
{
    public static void Main(string[] args)
    {
        Document doc = new Document("Initial Content. ");
        Caretaker caretaker = new Caretaker();

        caretaker.SaveState(doc);
        doc.Write("First change. ");
        caretaker.SaveState(doc);
        doc.Write("Second change. ");

        Console.WriteLine("Current Content: " + doc.GetContent());

        caretaker.Undo(doc);
        Console.WriteLine("After first undo: " + doc.GetContent());

        caretaker.Undo(doc);
        Console.WriteLine("After second undo: " + doc.GetContent());
    }
}
