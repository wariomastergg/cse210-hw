using System;

class Breatheing : Activity{
    public Breatheing(){
        _activity_name = "Breathing Activity";
        _activity_desctipt = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void breatheIn(int s){
        Console.Write("breathe in ");
        countDown(s);
        Console.Write("\n");
    }
    public void breatheOut(int s){
        Console.Write("breathe out ");
        countDown(s);
        Console.Write("\n");
    }
    public void breatheSession(){
        Welcome();
        getReady();
        int steps = ((_activity_time-(_activity_time%5))/5);
        for (int i = 0; i < steps; i++){
            breatheIn(3);
            breatheOut(2);
            Console.Write("\n");
        }
        if (_activity_time%5 > 0){
            breatheIn(_activity_time%5);
        }
        wellDone();
    }

}