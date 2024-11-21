using System;
using static Scripture;

//menu class b/c i needed a 3d class for some reason
public class Menu{


	public Menu(){}

	public void start_menu(){
		//Text tex = new Text("wow this is amazing");
        //List<int> idc = new() {0,2};

        //Console.WriteLine(tex.BlankWords(idc));
        Scripture script = new Scripture();
        String s = "";
        String inp = "";

        Console.Clear();

        s = script.display();
        Console.WriteLine(s);
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        
        inp = Console.ReadLine();

        while (inp != "quit" && !script._end){
            Console.Clear();
            
            s = script.produceBlanks();
            Console.WriteLine(script.produceBlanks());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            
            inp = Console.ReadLine();
        }
	}
}