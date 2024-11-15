public class Square : Shape{
    private double _side;

    public Square(double s){
        _side = s;
    }

    public Square(double s, String c){
        _side = s;
        _color = c;
    }

    public override double GetArea(){
        return _side * _side;
    }

    public override String Type(){return "Square";}
}