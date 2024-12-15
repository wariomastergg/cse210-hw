using System;

public class Vec2{

	public double _x;
	public double _y;

	public double _r => _x;
	public double _g => _y;


	//CONSTRUCTOR STUFF
	public Vec2( double x, double y ){
		_x = x;
		_y = y;
	}

	public Vec2( double n ){
		_x = n;
		_y = n;
	}

	//a thing for making a vector 2 without needing new
	//mainly just for writing code faster
	public static Vec2 vec2(double x, double y){
		return new Vec2(x,y);
	}
	public static Vec2 vec2( double n ){
		return new Vec2(n);
	}

	//GETTER STUFF
	public double x(){ return _x; }
	public double y(){ return _y; }

	//SETTER STUFF
	public void x( double x ){ _x = x; }
	public void y( double y ){ _y = y; }

	//OPERATOR STUFF

	//add
	public static Vec2 operator+ (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3._x = v1._x + v2._x ;
		v3._y = v1._y + v2._y ;
		return v3;
	}

	//subtract
	public static Vec2 operator- (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3._x = v1._x - v2._x ;
		v3._y = v1._y - v2._y ;
		return v3;
	}

	//multiply
	public static Vec2 operator* (Vec2 v1, Vec2 v2){
		Vec2 v3 = vec2(0.0);
		v3._x = v1._x * v2._x ;
		v3._y = v1._y * v2._y ;
		return v3;
	}
	public static Vec2 operator* (Vec2 v1, double s){
		Vec2 v3 = vec2(0.0);
		v3._x = v1._x * s ;
		v3._y = v1._y * s ;
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
		v3._x = v1._x / v2._x ;
		v3._y = v1._y / v2._y ;
		return v3;
	}
	public static Vec2 operator/ (Vec2 v1, double s){
		Vec2 v3 = vec2(0.0);
		v3._x = v1._x / s ;
		v3._y = v1._y / s ;
		return v3;
	}
	public static Vec2 operator/ (double s, Vec2 v1){
		Vec2 v3 = vec2(0.0);
		v3._x = s / v1._x ;
		v3._y = s / v1._y ;
		return v3;
	}




}