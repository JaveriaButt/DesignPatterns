using System;

// Step 1: Define the interface for message senders
interface IMessageSender
{
    void SendMessage(string message);
}

// Step 2: Implement concrete message senders
class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}

class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}

// Step 3: Define the abstraction
abstract class Message
{
    protected IMessageSender messageSender;

    protected Message(IMessageSender messageSender)
    {
        this.messageSender = messageSender;
    }

    public abstract void Send();
}

// Step 4: Implement concrete message classes
class TextMessage : Message
{
    private string _text;

    public TextMessage(IMessageSender messageSender, string text) : base(messageSender)
    {
        _text = text;
    }

    public override void Send()
    {
        messageSender.SendMessage($"Text Message: {_text}");
    }
}

class MultimediaMessage : Message
{
    private string _content;

    public MultimediaMessage(IMessageSender messageSender, string content) : base(messageSender)
    {
        _content = content;
    }

    public override void Send()
    {
        messageSender.SendMessage($"Multimedia Message: {_content}");
    }
}

// Step 5: Implement the messaging application
class MessagingApp
{
    static void Main(string[] args)
    {
        IMessageSender smsSender = new SmsSender();
        IMessageSender emailSender = new EmailSender();

        Message textMessage = new TextMessage(smsSender, "Hello, how are you?");
        Message multimediaMessage = new MultimediaMessage(emailSender, "Image attachment");

        textMessage.Send();
        multimediaMessage.Send();
    }
}
