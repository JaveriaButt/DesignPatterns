using System;

// Target interface
interface IShape
{
    void Draw();
}

// Adaptee class
class Square
{
    public void DrawSquare(int size)
    {
        Console.WriteLine($"Drawing square of size {size}");
    }
}

// Object Adapter
class SquareObjectAdapter : IShape
{
    private Square _square;

    public SquareObjectAdapter(Square square)
    {
        _square = square;
    }

    public void Draw()
    {
        _square.DrawSquare(Size);
    }

    public int Size { get; set; }
}

// Class Adapter
class SquareClassAdapter : Square, IShape
{
    public void Draw()
    {
        DrawSquare(Size);
    }

    public int Size { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Using Object Adapter
        Console.WriteLine("Drawing square using Object Adapter:");
        Square square = new Square();
        square.Size = 5;
        IShape squareObjectAdapter = new SquareObjectAdapter(square);
        squareObjectAdapter.Draw();
        Console.WriteLine();

        // Using Class Adapter
        Console.WriteLine("Drawing square using Class Adapter:");
        IShape squareClassAdapter = new SquareClassAdapter();
        ((SquareClassAdapter)squareClassAdapter).Size = 5;
        squareClassAdapter.Draw();
    }
}
