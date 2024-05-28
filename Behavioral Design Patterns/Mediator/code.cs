using System;
using System.Collections.Generic;

public interface IMediator
{
    void SendMessage(string message, Colleague colleague);
    void AddColleague(Colleague colleague);
}

public class ConcreteMediator : IMediator
{
    private List<Colleague> colleagues = new List<Colleague>();

    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague colleague)
    {
        foreach (var col in colleagues)
        {
            if (col != colleague)
            {
                col.Receive(message);
            }
        }
    }
}

public abstract class Colleague
{
    protected IMediator mediator;

    public Colleague(IMediator mediator)
    {
        this.mediator = mediator;
    }

    public void Send(string message)
    {
        mediator.SendMessage(message, this);
    }

    public abstract void Receive(string message);
}

public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(IMediator mediator) : base(mediator) { }

    public override void Receive(string message)
    {
        Console.WriteLine("ConcreteColleague1 received: " + message);
    }
}

public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(IMediator mediator) : base(mediator) { }

    public override void Receive(string message)
    {
        Console.WriteLine("ConcreteColleague2 received: " + message);
    }
}

public class MediatorPatternExample
{
    public static void Main(string[] args)
    {
        IMediator mediator = new ConcreteMediator();

        Colleague colleague1 = new ConcreteColleague1(mediator);
        Colleague colleague2 = new ConcreteColleague2(mediator);

        mediator.AddColleague(colleague1);
        mediator.AddColleague(colleague2);

        colleague1.Send("Hello from Colleague 1");
        colleague2.Send("Hi there from Colleague 2");

        // Output:
        // ConcreteColleague2 received: Hello from Colleague 1
        // ConcreteColleague1 received: Hi there from Colleague 2
    }
}
