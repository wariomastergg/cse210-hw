using System;

public class Fraction{

    private int numerator;
    private int denominator;

    public Fraction(){
        numerator = 1;
        denominator = 1;
    }

    public Fraction(int n){
        numerator = n;
        denominator = 1;
    }

    public Fraction(int n, int d){
        numerator = n;
        denominator = d;
    }
    public String GetFractionString(){
        return $"{numerator}/{denominator}";
    }
    public double GetDecimalValue(){
        return (double)numerator/denominator;
    }
    //public override String ToString(){
    //    return "wow";
    //}
}