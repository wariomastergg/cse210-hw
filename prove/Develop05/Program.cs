using System;
using System.IO; 


public abstract class Goal{
    protected int _type;

    protected String _goal_name;
    protected String _goal_description;
    protected int _goal_points;
    protected bool _completed = false;
    protected int _times_completed = 0;
    

    public Goal(){}

    public virtual String getGoalName(){
        return _goal_name;
    }
    public virtual int getGoalPoints(){
        return _goal_points;
    }

    public virtual void promptUserNewGoal(){
        Console.Write("what is the name of your goal? ");
        _goal_name = Console.ReadLine();
        Console.Write("what is a shot description of it? ");
        _goal_description = Console.ReadLine();
        Console.Write("what is the amount of poins associates with this goal? ");
        _goal_points = int.Parse(Console.ReadLine());
    }
    
    public abstract void markGoal();

    public abstract int calulatePoints();

    public virtual void displayGoal(){
        String a;
        if (_completed){
            a = "X";
        }
        else{
            a = " ";
        }
        Console.WriteLine($"[{a}] {_goal_name} ({_goal_description})");
    }

    public virtual String Serialize(){
        return $"{_goal_name},{_goal_description},{_goal_points},{_completed},{_times_completed}";
    }
    public virtual void Deserialize(String s){
        string[] items = s.Split(",");
        _goal_name = items[0];
        _goal_description = items[1];
        _goal_points = int.Parse(items[2]);
        _completed = bool.Parse(items[3]);
        _times_completed = int.Parse(items[4]);
    }

    public virtual int getType(){
        return _type;
    }
}

public class Simple : Goal{


    public Simple(){
        _type = 0;
    }

    public override void markGoal(){
        _times_completed += 1;
        _completed = true;
    }

    public  override int calulatePoints(){
        if (_completed){
            return _goal_points;
        }
        return 0;
    }
}

public class Eternal : Goal{
    public Eternal(){
        _type = 1;
    }

    public override void markGoal(){
        _times_completed += 1;
    }

    public override int calulatePoints(){
        return _goal_points * _times_completed;
    }   
}

public class Checklist : Goal{

    private int _bonus_multiple;
    private int _bonus_points;

    public Checklist(){
        _type = 2;
    }

    public override int getGoalPoints(){
        if (_times_completed == _bonus_multiple){
            return _goal_points + _bonus_points;
        }
        return _goal_points;
    }
    public override void promptUserNewGoal(){
        Console.Write("what is the name of your goal? ");
        _goal_name = Console.ReadLine();
        Console.Write("what is a shot description of it? ");
        _goal_description = Console.ReadLine();
        Console.Write("what is the amount of poins associates with this goal? ");
        _goal_points = int.Parse(Console.ReadLine());
        Console.Write("how many times does this goal need to be completed for a bonus? ");
        _bonus_multiple = int.Parse(Console.ReadLine());
        Console.Write("what is the bonus for accomplising it that many times? ");
        _bonus_points = int.Parse(Console.ReadLine());
    }

    public override void markGoal(){
        _times_completed += 1;
        if (_times_completed >= _bonus_multiple){
            _completed = true;
        }
    }

    public override int calulatePoints(){
        int points = (_times_completed*_goal_points);
        if (_completed){
            points += _bonus_points;
        }
        return points;
    }

    public override void displayGoal(){
        String a;
        if (_completed){
            a = "X";
        }
        else{
            a = " ";
        }
        Console.WriteLine($"[{a}] {_goal_name} ({_goal_description}) -- Currently completed: {_times_completed}/{_bonus_multiple}");
    }

    public override String Serialize(){
        return $"{_goal_name},{_goal_description},{_goal_points},{_completed},{_times_completed},{_bonus_multiple},{_bonus_points}";
    }
    public override void Deserialize(String s){
        string[] items = s.Split(",");
        _goal_name = items[0];
        _goal_description = items[1];
        _goal_points = int.Parse(items[2]);
        _completed = bool.Parse(items[3]);
        _times_completed = int.Parse(items[4]);
        _bonus_multiple = int.Parse(items[5]);
        _bonus_points = int.Parse(items[6]);
    }
    
}

public class GoalManager{
    private List<Goal> _goals;
    public GoalManager(){
        _goals = new();
    }

    public void addGoal(Goal g){

        _goals.Add(g);
    }

    public List<Goal> getGoals(){
        return _goals;
    }

    public void Save(String filename){
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal a in _goals){
                outputFile.WriteLine(a.getType());
                outputFile.WriteLine(a.Serialize());
            }
        }
    }

    public void Load(String filename){

        _goals = new();

        string[] lines = System.IO.File.ReadAllLines(filename);
        for (int i = 0; i < lines.Count(); i+=2){
            switch(lines[i]){
                case "0":
                Simple a = new Simple();
                a.Deserialize(lines[i+1]);
                _goals.Add(a);
                break;

                case "1":
                Eternal b = new Eternal();
                b.Deserialize(lines[i+1]);
                _goals.Add(b);
                break;

                case "2":
                Checklist c = new Checklist();
                c.Deserialize(lines[i+1]);
                _goals.Add(c);
                break;
            }
            
        }
    }

    public int getPointsSum(){
        int sum = 0;
        foreach (Goal i in _goals){
            sum += i.calulatePoints();
        }
        return sum;
    }


}

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