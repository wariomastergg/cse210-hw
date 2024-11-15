using System;
using static Shape;

class Program
{
    static void Main(string[] args)
    {
        List<String> cols = new(){"red", "green", "blue", "orange", "yellow", "purple"};
        List<Shape> shaps = new();

        Random rand = new Random();

        for (int i = 0; i < 10; i++){

            String c = cols[rand.Next(0, cols.Count())];
            int n1 = rand.Next(0, 10);
            int n2 = rand.Next(0, 10);

            switch (rand.Next(0, 3)){
                case 0:
                Square s = new Square(n1, c);
                shaps.Add(s);
                break;

                case 1:
                Rectangle r = new Rectangle(n1, n2, c);
                shaps.Add(r);
                break;
                
                case 2:
                Circle ci = new Circle(n1, c);
                shaps.Add(ci);
                break;
            }

            
        }
        for (int i = 0; i < 10; i++){
            Console.WriteLine($"Shape type: {shaps[i].Type()}");
            Console.WriteLine(shaps[i].GetColor());
            Console.WriteLine(shaps[i].GetArea());
            Console.WriteLine();
        }
    }
}