using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName(){
        Console.Write("What is your name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber(){
        Console.Write("What is your favorite number? ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber( int a ){
        return a*a;
    }
    static void DisplayResult(String name, int num){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int num = SquareNumber(PromptUserNumber());
        DisplayResult(name, num);

    }
}