using System;


using static Breatheing;
using static Pondering;
using static Listing;


class Activity{
    
    private List<String> line = new(){"/", "-", "\\", "-", "|" };
    public int _activity_time = 0;
    public String _activity_name;
    public String _activity_desctipt;
    public Activity(){}

    public void promptActivityTime(){
        Console.Write("how long in seconds would you like your session?");
        _activity_time = Int32.Parse( Console.ReadLine() );
    }

    public void countDown(int s){
        for (int i = s; i > 0; i--){
            Console.Write(i);
            Console.Write("\b");
            Thread.Sleep(1000);
        }
    }

    public void  dial( int s ){
        for (int i = 0; i < 10*s; i++){
            Console.Write("\b");
            Console.Write(line[i%5]);
            Thread.Sleep(100);
        }
        Console.Write("\b");
    }

    public void getReady(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        dial(5);
    }

    public void Welcome(){
        Console.Clear();
        Console.WriteLine($"welcome to the {_activity_name}\n");
        Console.WriteLine(_activity_desctipt);
        Console.WriteLine("\n");
        promptActivityTime();
    }

    public void wellDone(){
        Console.WriteLine("Well Done!");
        dial(5);
        Console.Write("\n");
        Console.WriteLine($"you have completed another {_activity_time} second(s) of the {_activity_name}");
        dial(5);
    }
}