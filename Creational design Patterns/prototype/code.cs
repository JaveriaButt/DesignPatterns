using System;

// Prototype interface
interface IShape
{
    IShape Clone(); // Make a copy of itself
    void Draw(); // Draw the shape
}

// Concrete prototype
class Circle : IShape
{
    private string color;

    // When you create a circle, you give it a color.
    public Circle(string color)
    {
        this.color = color;
    }

    // This creates a copy of the circle.
    public IShape Clone()
    {
        return new Circle(this.color);
    }

    // This is how a circle draws itself.
    public void Draw()
    {
        Console.WriteLine("Drawing a " + color + " circle.");
    }
}

// Client code
class ShapeClient
{
    private IShape shapePrototype;

    // When you create a client, you give it a prototype (a shape).
    public ShapeClient(IShape shapePrototype)
    {
        this.shapePrototype = shapePrototype;
    }

    // This method creates a new shape using the prototype.
    public IShape CreateShape()
    {
        return shapePrototype.Clone();
    }
}

// Main class
class PrototypeExample
{
    static void Main(string[] args)
    {
        // Create a concrete prototype (a red circle).
        IShape circlePrototype = new Circle("red");

        // Create a client and give it the prototype.
        ShapeClient client = new ShapeClient(circlePrototype);

        // Use the prototype to create a new shape (a red circle).
        IShape redCircle = client.CreateShape();

        // Draw the newly created red circle.
        redCircle.Draw();
    }
}
