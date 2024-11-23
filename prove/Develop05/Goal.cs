using System;
using System.IO;

using static Simple;
using static Eternal;
using static Checklist;

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