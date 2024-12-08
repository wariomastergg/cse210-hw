using System;
using static Vector;

public class Vec2 : Vector{

	//CONSTRUCTOR STUFF
	public Vec2( double X, double Y ){
		x = X;
		y = Y;
	}

	public Vec2( double n ){
		x = n;
		y = n;
	}

	//a thing for making a vector 2 without needing new
	//mainly just for writing code faster
	public static Vec2 vec2(double X, double Y){
		return new Vec2(X,Y);
	}
	public static Vec2 vec2( double n ){
		return new Vec2(n);
	}

	//GETTER STUFF
	public double X(){ return x; }
	public double Y(){ return y; }
	public double Z(){ return x; }

	//SETTER STUFF
	public void X( double X ){ x = X; }
	public void Y( double Y ){ y = Y; }

	//OPERATOR STUFF

	//add
	public static Vec2 operator+ (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x + v2.x ;
		v3.y = v1.y + v2.y ;
		return v3;
	}

	//subtract
	public static Vec2 operator- (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x - v2.x ;
		v3.y = v1.y - v2.y ;
		return v3;
	}

	//multiply
	public static Vec2 operator* (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x * v2.x ;
		v3.y = v1.y * v2.y ;
		return v3;
	}
	public static Vec2 operator* (Vec2 v1, double s){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x * s ;
		v3.y = v1.y * s ;
		return v3;
	}
	public static Vec2 operator* (double s, Vec2 v1){
		Vec2 v3 = vec2(0.0);
		v3 = v3 * s;
		return v3;
	}

	//devide
	public static Vec2 operator/ (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x / v2.x ;
		v3.y = v1.y / v2.y ;
		return v3;
	}
	public static Vec2 operator/ (Vec2 v1, double s){
		Vec2 v3 = vec2(0.0);
		v3.x = v1.x / s ;
		v3.y = v1.y / s ;
		return v3;
	}
	public static Vec2 operator/ (double s, Vec2 v1){
		Vec2 v3 = vec2(0.0);
		v3.x = s / v1.x ;
		v3.y = s / v1.y ;
		return v3;
	}
}