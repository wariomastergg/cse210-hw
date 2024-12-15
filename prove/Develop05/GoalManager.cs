using System;
using System.IO;
using static Goal;

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