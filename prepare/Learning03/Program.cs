using System;

using static Fraction;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

         f = new Fraction(8);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

         f = new Fraction(4, 7);
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());
    }
}