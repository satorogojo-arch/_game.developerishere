using System;
using System.Collections.Generic;

public class PeriodicTable
{
    static void Main()
    {
        var elements = new List<Element>
        {
            new Element (1,"H","Hydrogen"),
            new Element (2,"He","Hellium"),
            new Element (3,"Li","Lithium"),
            new Element(4,"Be","Beryllium"),
            new Element (5,"B","Boron"),
            new Element (6,"C","Carbon"),
            new Element (7,"N","Nitrogen"),
            new Element (7,"N","Nitrogen"),
            new Element (8,"O","Oxygen"),
            new Element (9,"F","Flourine"),
            new Element (10,"Ne","Neon"),
            new Element (11,"Na","Sodium"),
            new Element (12,"Mg","Magnesium"),
            new Element (13,"Al","Aluminum"),
            new Element (14,"Si","Silicon"),
            new Element (15,"P","Phosporus"),
            new Element (16,"S","Sulphur"),
            new Element (17,"Cl","Chlorine"),
            new Element (18,"Ar","Argon"),
            new Element (19,"K","Potassium"),
            new Element (20,"Ca","Calcium"),
        };
        Console.WriteLine("Number\tSymbol\tName");
        foreach (var el in elements)
        {
            Console.WriteLine($"{el.Number}\t{el.Symbol}\t{el.Name}");
        }
    }
}
class Element
{
    public int Number { get; }
    public string Symbol { get; }
    public string Name { get; }

    public Element(int number, string symbol, string name)
    {
        Number = number;
        Symbol = symbol;
        Name = name;
    }
}

