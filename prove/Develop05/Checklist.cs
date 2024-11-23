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