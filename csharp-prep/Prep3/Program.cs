using System;

class Program
{
    static void Main(string[] args)
    {
        
        String again = "yes";
        while (again == "yes"){
        
            //initiate the guess number and the number of trys
            int trys = 0;
            int guess = -1;
            

            Random rand = new Random();
            int number = rand.Next(1, 101);
        
            while (guess != number){
    
                //increment the number of trys
                trys++;
                
                //prompt the user to guess a secret number
                Console.Write("guess my secret number between 1 and 100 inclusive: ");
                guess = int.Parse(Console.ReadLine());
    
                //tell the user if they need to guess higher or lower
                if ( guess > number ){
                    Console.WriteLine("Lower");
                }
                else if ( guess < number ){
                    Console.WriteLine("Higher");
                }


            }
            Console.WriteLine($"you got it! my secret number is {number}.");
            Console.WriteLine($"it took you {trys} try(s).\n");

            Console.Write("would you like to try again?(yes or no): ");
            again = Console.ReadLine();

        }
        
        
    }
}