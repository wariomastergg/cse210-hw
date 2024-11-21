using static Square;
using static Rectangle;
using static Circle;

public abstract class Shape{
    protected String _color;

    public Shape(){}

    public String GetColor(){
        return _color;
    }

    public void SetColor(String c){
        _color = c;
    }

    public abstract double GetArea();

    public abstract String Type();
}