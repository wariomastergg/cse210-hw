using System;
using static Assignment;
using static MathAssignment;
using static WritingAssignment;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment();
        a.setName("bozo");
        a.setTopic("stuff");
        Console.WriteLine(a.GetSummary());

        MathAssignment m = new MathAssignment( "1-2", "3");
        m.setName("Roberto Rodriguez");
        m.setTopic("Fractions");
        Console.WriteLine(m.GetSummary());
        Console.WriteLine(m.GetHomeworkList());

        WritingAssignment w = new WritingAssignment( "The Causes of World War II by Mary Waters" );
        w.setName("Mary Waters");
        w.setTopic("European History");
        Console.WriteLine(w.GetSummary());
        Console.WriteLine(w.GetWritingInformation());
        
        
    }
}