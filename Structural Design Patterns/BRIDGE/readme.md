Scenario:

Let's consider a scenario where we're developing a messaging application that supports different message types (e.g., text messages, multimedia messages) and different platforms for sending messages (e.g., SMS, email). We want to implement the messaging functionality in a way that allows us to add new message types or messaging platforms without modifying existing code.

Step-by-Step Solution:

Define an interface IMessageSender to represent different messaging platforms (e.g., SMS, email).
Implement classes for each messaging platform (e.g., SmsSender, EmailSender), each providing its own implementation of sending messages.
Define an abstract class Message to represent different types of messages in the application. This class will have a reference to an IMessageSender object.
Implement concrete message classes (e.g., TextMessage, MultimediaMessage) that inherit from the Message class and provide specific implementations for sending messages.
Implement the messaging application by creating instances of messages and assigning appropriate messaging platforms to them.