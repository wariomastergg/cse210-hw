using System;

class Program
{
    static void Main(string[] args)
    {
        //make list for numbers
        List<int> nums = new();
        int number = -1;
        while (number != 0){
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0){ break; }
            nums.Add(number);
        }

        int sum = 0;
        int most = nums[0];
        foreach ( int i in nums ){
            sum += i;
            //Console.WriteLine(i);
            if ( i > most ){
                most = i;
            }

        }
     

        


        Console.WriteLine($"the sum is: {sum}");
        Console.WriteLine($"the average is: {(double)(sum/nums.Count)}");
        Console.WriteLine($"the largest number is: {most}");


        //get length of list
        int length = nums.Count;


        
        
    }
}