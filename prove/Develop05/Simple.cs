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