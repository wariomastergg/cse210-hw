using System;


class Program
{
    static void Main(string[] args)
    {
        //get the grade as an integer
        Console.Write("whats your grade %? (0-100): ");
        int grade = int.Parse(Console.ReadLine());
        String letter = "F";
        String sign = "";

        if (grade >= 90){
            letter = "A";

        }
        else if (grade >= 80){
            letter = "B";
        }
        else if (grade >= 70){
            letter = "C";
        }
        else if (grade >= 60){
            letter = "D";
        }
        else if (grade < 60){
            letter = "F";
        }
        else {
            Console.WriteLine("why did you type that? GET OUT!!!!");

        }

        // find the + or - in the grade
        if (grade > 92 || grade < 60){
            sign = "";
        }
        else if ( (grade % 10) >= 7 ){
            sign = "+";
        }
        else if ( (grade % 10) < 3 ){
            sign = "-";
        }


        Console.WriteLine($"you got a {letter}{sign}");
        if (grade >= 70){
            Console.WriteLine("you passed!");
        }
        else {
            Console.WriteLine("you didn't pass. :(");
        }

    }
}