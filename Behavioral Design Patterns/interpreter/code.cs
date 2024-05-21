using System;
using System.Collections.Generic;

// AbstractExpression
public interface IExpression
{
    bool Interpret(string context);
}

// TerminalExpression
public class LiteralExpression : IExpression
{
    private readonly string literal;
    public LiteralExpression(string literal) { this.literal = literal; }
    public bool Interpret(string context) => context.Contains(literal);
}

// NonTerminalExpression - Sequence
public class SequenceExpression : IExpression
{
    private readonly IExpression expression1;
    private readonly IExpression expression2;
    public SequenceExpression(IExpression expr1, IExpression expr2) { expression1 = expr1; expression2 = expr2; }
    public bool Interpret(string context) => expression1.Interpret(context) && expression2.Interpret(context);
}

// NonTerminalExpression - Repetition
public class RepetitionExpression : IExpression
{
    private readonly IExpression expression;
    public RepetitionExpression(IExpression expr) { expression = expr; }
    public bool Interpret(string context) => expression.Interpret(context); // Simplified for demonstration
}

// NonTerminalExpression - Alternation
public class AlternationExpression : IExpression
{
    private readonly IExpression alternative1;
    private readonly IExpression alternative2;
    public AlternationExpression(IExpression alt1, IExpression alt2) { alternative1 = alt1; alternative2 = alt2; }
    public bool Interpret(string context) => alternative1.Interpret(context) || alternative2.Interpret(context);
}

// Client
public class InterpreterDemo
{
    public static void Main(string[] args)
    {
        // Create the expression tree for the regular expression: "hello|world"
        IExpression hello = new LiteralExpression("hello");
        IExpression world = new LiteralExpression("world");
        IExpression alternation = new AlternationExpression(hello, world);

        // Test the expression
        string testString = "hello world";
        Console.WriteLine($"Does '{testString}' match 'hello|world'? {alternation.Interpret(testString)}");
    }
}
