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