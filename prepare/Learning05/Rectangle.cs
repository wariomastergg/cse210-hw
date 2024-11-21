public class Rectangle : Shape{
    private double _length;
    private double _width;

    public Rectangle(double l, double w){
        _length = l;
        _width = w;
    }

    public Rectangle(double l, double w, String c){
        _length = l;
        _width = w;
        _color = c;
    }

    public override double GetArea(){
        return _length * _width;
    }

    public override String Type(){return "Rectangle";}
}