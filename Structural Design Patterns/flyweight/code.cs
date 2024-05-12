using System;
using System.Collections.Generic;

// Step 1: Define Flyweight Interface
interface IGlyph
{
    void Display(char character);
}

// Step 2: Implement Concrete Flyweight
class Character : IGlyph
{
    private char _characterCode;
    private string _font;

    public Character(char characterCode, string font)
    {
        _characterCode = characterCode;
        _font = font;
    }

    public void Display(char character)
    {
        Console.WriteLine($"Displaying character '{_characterCode}' in font '{_font}'");
    }
}

// Step 3: Implement Unshared Concrete Flyweight
class Row : IGlyph
{
    private List<IGlyph> _characters = new List<IGlyph>();

    public void AddCharacter(IGlyph character)
    {
        _characters.Add(character);
    }

    public void Display(char character)
    {
        foreach (var c in _characters)
        {
            c.Display(character);
        }
    }
}

// Step 4: Implement Flyweight Factory
class GlyphFactory
{
    private Dictionary<char, IGlyph> _characterPool = new Dictionary<char, IGlyph>();

    public IGlyph GetCharacter(char characterCode, string font)
    {
        if (!_characterPool.ContainsKey(characterCode))
        {
            _characterPool[characterCode] = new Character(characterCode, font);
        }
        return _characterPool[characterCode];
    }
}

// Step 5: Client Code
class Client
{
    static void Main(string[] args)
    {
        GlyphFactory factory = new GlyphFactory();

        // Create characters
        IGlyph characterA = factory.GetCharacter('A', "Arial");
        IGlyph characterB = factory.GetCharacter('B', "Arial");
        IGlyph characterC = factory.GetCharacter('C', "Times New Roman");

        // Create row and add characters
        Row row = new Row();
        row.AddCharacter(characterA);
        row.AddCharacter(characterB);
        row.AddCharacter(characterC);

        // Display characters in row
        row.Display('X'); // Displaying character 'A' in font 'Arial'
                          // Displaying character 'B' in font 'Arial'
                          // Displaying character 'C' in font 'Times New Roman'
    }
}
