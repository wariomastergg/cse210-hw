public class Circle : Shape{
    private double _radius;

    public Circle(double r){
        _radius = r;
    }
    public Circle(double r, String c){
        _radius = r;
        _color = c;
    }

    public override double GetArea(){
        return Math.PI * _radius * _radius;
    }
    public override String Type(){return "Circle";}

}