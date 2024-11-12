using System;
using static Activity;

class Program
{
    static void Main(string[] args)
    {   
        Breatheing a = new();
        Pondering b = new();
        Listing c = new();

        String resp = "";
        while(resp != "4"){
            Console.Clear();
            Console.WriteLine("menu options");
            Console.WriteLine("1. breatheing activity\n2. pondering activity\n3. listing activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            resp = Console.ReadLine();
            switch(resp){
                case "1":
                a.breatheSession();
                break;

                case "2":
                b.ponderingSession();
                break;

                case "3":
                c.listingSession();
                break;

                case "4":
                break;

                default:
                Console.WriteLine("uhhh...");
                break;
            }
        }
    }
}