using System;

public interface ISaveStrategy
{
    void Save(string content);
}

public class PlainTextSaveStrategy : ISaveStrategy
{
    public void Save(string content)
    {
        Console.WriteLine("Saving as plain text: " + content);
    }
}

public class HtmlSaveStrategy : ISaveStrategy
{
    public void Save(string content)
    {
        Console.WriteLine("Saving as HTML: <p>" + content + "</p>");
    }
}

public class MarkdownSaveStrategy : ISaveStrategy
{
    public void Save(string content)
    {
        Console.WriteLine("Saving as Markdown: **" + content + "**");
    }
}

public class Document
{
    private string content;
    private ISaveStrategy saveStrategy;

    public Document(string content)
    {
        this.content = content;
    }

    public void SetSaveStrategy(ISaveStrategy saveStrategy)
    {
        this.saveStrategy = saveStrategy;
    }

    public void Save()
    {
        saveStrategy.Save(content);
    }
}

public class StrategyPatternExample
{
    public static void Main(string[] args)
    {
        Document doc = new Document("Hello, Strategy Pattern!");

        doc.SetSaveStrategy(new PlainTextSaveStrategy());
        doc.Save();

        doc.SetSaveStrategy(new HtmlSaveStrategy());
        doc.Save();

        doc.SetSaveStrategy(new MarkdownSaveStrategy());
        doc.Save();
    }
}
