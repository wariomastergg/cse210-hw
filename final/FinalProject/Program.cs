using System;
using Raylib_cs;

using static Vec2;

class Program
{
    static void Main(string[] args)
    {

        Raylib.InitWindow(800, 480, "Hello World");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);
            Raylib.DrawRectangle(100, 100, 10, 10, Color.Black);
            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();

        //Vec2 b = vec2( 3.0, 5.0 );
        //Vec2 a = vec2( 2.0, 6.0 );
        //Console.WriteLine( a._r );
        //Console.WriteLine( (2.0 * a)._r );
        ////Console.WriteLine( (a + b)._g );
        //Console.WriteLine( a._r );
    }
}