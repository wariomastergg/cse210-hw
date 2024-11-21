using System;
using static Entry;
using static Journal;
using System.IO;

using System.Text.Json;


class Program
{
    static void Main(string[] args){


        Journal j = new Journal();

        String input = "";


        while (input != "5"){



            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("What would you like to do? ");
            input = Console.ReadLine();

            switch(input){
                case "1":
                j.addEntry();
                break;

                case "2":
                j.displayEntries();
                break;

                case "3":
                //realistically it can be any text file but i'm just keeping the json naming convention
                Console.WriteLine("what is the filename? (give in the format of {name}.json)");
                j.readFromFile(Console.ReadLine());
                break;

                case "4":
                Console.WriteLine("what is the filename? (give in the format of {name}.json)");
                j.writeToFile(Console.ReadLine());
                break;

                case "5":
                break;

                default:
                break;

            }
        }

        //string output = JsonConvert.SerializeObject("wow");
        //Console.WriteLine(output);
        //using (StreamWriter wfile = new StreamWriter("wow.txt"))
        //{
        //        wfile.WriteLine("nice");
        //}
        //using (StreamReader rfile = new StreamReader("wow.txt"))
        //{
        //        rfile.WriteLine(file.ReadToEnd());
        //}

        //Journal a = new Journal();
        //a.addEntry();
        //a.addEntry();
        //a.displayEntries();
        //a.writeToFile("save.json");

        //a.readFromFile("save.json");
        //a.displayEntries();

        //String jsn = JsonSerializer.Serialize(a);
        //using (StreamWriter wfile = new StreamWriter("wow.txt"))
        //{
        //    wfile.WriteLine(jsn);
        //}
        //using (StreamReader rfile = new StreamReader("wow.txt"))
        //{
        //        rfile.WriteLine(file.ReadToEnd());
        //        Journal b = JsonSerializer.Deserialize<Journal>(file.ReadToEnd());
        //        b.displayEntries();
        //}

        //Console.WriteLine(jsn);
        //Journal b = JsonSerializer.Deserialize<Journal>(jsn);
        //b.displayEntries();
        

        //var c = JsonSerializer.Parse(jsn);
        //dynamic stuff = JsonConvert.DeserializeObject(jsn);
        //Entry save = JsonSerializer.Deserialize(jsn, <Entry>);
        //save.displayEntries();
        //Journal a = new Journal();
        //a.addEntry();
        //a.addEntry();
        //a.addEntry();
        //a.displayEntries();

    }
}