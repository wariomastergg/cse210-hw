using System;
using System.IO;

using static Goal;
using static GoalManager;

class Program
{
    static void Main(string[] args)
    {

        GoalManager g = new GoalManager();

        bool running = true;

        while(running){
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1. Create New Goals\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            String input = Console.ReadLine();

            switch(input){
                case "1":
                Console.WriteLine("The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n");
                Console.Write("Which type of goal would you like to create?");
                String pick = Console.ReadLine();
                switch(pick){
                    case "1":
                    Simple a = new Simple();
                    a.promptUserNewGoal();
                    g.addGoal(a);
                    break;

                    case "2":
                    Eternal b = new Eternal();
                    b.promptUserNewGoal();
                    g.addGoal(b);
                    break;

                    case "3":
                    Checklist c = new Checklist();
                    c.promptUserNewGoal();
                    g.addGoal(c);
                    break;
                }

                break;

                case "2":
                List<Goal> goals = g.getGoals();
                Console.WriteLine("\nyour goals are:");
                for (int i = 0; i < goals.Count(); i++){
                    Console.Write($"{i+1}. ");
                    goals[i].displayGoal();
                }
                Console.WriteLine($"\nYou have {g.getPointsSum()} point(s)\n");
                break;

                case "3":
                Console.Write("whats the filename for the goal file? ");
                String filenameS = Console.ReadLine();
                g.Save(filenameS);
                Console.Write("\n");
                break;

                case "4":
                Console.Write("whats the filename for the goal file? ");
                String filenameL = Console.ReadLine();
                g.Load(filenameL);
                Console.Write("\n");
                break;

                case "5":
                List<Goal> goals2 = g.getGoals();
                Console.WriteLine("\nthe goals are:");
                for (int i = 0; i < goals2.Count(); i++){
                    Console.Write($"{i+1}. ");
                    Console.WriteLine(goals2[i].getGoalName());
                }
                Console.Write("which goal did you accomplish? ");
                int mrk = int.Parse(Console.ReadLine());
                goals2[mrk-1].markGoal();
                Console.WriteLine($"Congradulations you earned {goals2[mrk-1].getGoalPoints()} point(s)!");
                Console.WriteLine($"\nYou now have {g.getPointsSum()} point(s)\n");
                break;

                case "6":
                running = false;
                break;
            }


        }
    }
}