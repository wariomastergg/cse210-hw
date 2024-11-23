using System;

using static Vec2;

class Program
{
    static void Main(string[] args)
    {
        Vec2 a = vec2( 2.0, 6.0 );
        Vec2 b = vec2( 3.0, 5.0 );

        Console.WriteLine( a._r );
        Console.WriteLine( (2.0 * a)._r );
        //Console.WriteLine( (a + b)._g );
        Console.WriteLine( a._r );
    }
}