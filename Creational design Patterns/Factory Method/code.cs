using System;

public class Main
{
    public static void Main(string[] args)
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        // Creating Circle
        Shape circle = shapeFactory.GetShape("CIRCLE");
        circle.Draw();

        // Creating Rectangle
        Shape rectangle = shapeFactory.GetShape("RECTANGLE");
        rectangle.Draw();

        // Creating Square
        Shape square = shapeFactory.GetShape("SQUARE");
        square.Draw();
    }
}

// ShapeFactory.cs
public class ShapeFactory
{
    public Shape GetShape(string shapeType)
    {
        if (shapeType == null)
        {
            return null;
        }
        else if (shapeType.Equals("CIRCLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Circle();
        }
        else if (shapeType.Equals("RECTANGLE", StringComparison.OrdinalIgnoreCase))
        {
            return new Rectangle();
        }
        else if (shapeType.Equals("SQUARE", StringComparison.OrdinalIgnoreCase))
        {
            return new Square();
        }
        return null;
    }
}

// Shape.cs
public interface Shape
{
    void Draw();
}

// Circle.cs
public class Circle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Inside Circle's draw method");
    }
}

// Rectangle.cs
public class Rectangle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Inside Rectangle's draw method");
    }
}

// Square.cs
public class Square : Shape
{
    public void Draw()
    {
        Console.WriteLine("Inside Square's draw method");
    }
}
