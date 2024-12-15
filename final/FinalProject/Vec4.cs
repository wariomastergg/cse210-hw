using System;
using static Vector;

public class Vec4 : Vector{

	//CONSTRUCTOR STUFF
	public Vec4( double X, double Y, double Z, double W ){
		x = X;
		y = Y;
		z = Z;
		w = W;
	}

	public Vec4( double n ){
		x = n;
		y = n;
		z = n;
		w = n;
	}

	//a thing for making a vector 2 without needing new
	//mainly just for writing code faster
	public static Vec4 vec4(double X, double Y, double Z, double W){
		return new Vec4(X,Y,Z,W);
	}
	public static Vec4 vec4( double n ){
		return new Vec4(n);
	}

	//GETTER STUFF
	public double X(){ return x; }
	public double Y(){ return y; }
	public double Z(){ return y; }
	public double W(){ return w; }

	//SETTER STUFF
	public void X( double X ){ x = X; }
	public void Y( double Y ){ y = Y; }
	public void Z( double X ){ x = X; }
	public void W( double W ){ w = W; }

	

	//OPERATOR STUFF

	//add
	public static Vec4 operator+ (Vec4 v1, Vec4 v2){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x + v2.x ;
		v3.y = v1.y + v2.y ;
		v3.z = v1.z + v2.z ;
		v3.w = v1.w + v2.w ;
		return v3;
	}

	//subtract
	public static Vec4 operator- (Vec4 v1, Vec4 v2){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x - v2.x ;
		v3.y = v1.y - v2.y ;
		v3.z = v1.z - v2.z ;
		v3.w = v1.w - v2.w ;
		return v3;
	}

	//multiply
	public static Vec4 operator* (Vec4 v1, Vec4 v2){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x * v2.x ;
		v3.y = v1.y * v2.y ;
		v3.z = v1.z * v2.z ;
		v3.w = v1.w * v2.w ;
		return v3;
	}
	public static Vec4 operator* (Vec4 v1, double s){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x * s ;
		v3.y = v1.y * s ;
		v3.z = v1.z * s ;
		v3.w = v1.w * s ;
		return v3;
	}
	public static Vec4 operator* (double s, Vec4 v1){
		Vec4 v3 = vec4(0.0);
		v3 = v3 * s;
		return v3;
	}

	//devide
	public static Vec4 operator/ (Vec4 v1, Vec4 v2){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x / v2.x ;
		v3.y = v1.y / v2.y ;
		v3.z = v1.z / v2.z ;
		v3.w = v1.w / v2.w ;
		return v3;
	}
	public static Vec4 operator/ (Vec4 v1, double s){
		Vec4 v3 = vec4(0.0);
		v3.x = v1.x / s ;
		v3.y = v1.y / s ;
		v3.z = v1.z / s ;
		v3.w = v1.w / s ;
		return v3;
	}
	public static Vec4 operator/ (double s, Vec4 v1){
		Vec4 v3 = vec4(0.0);
		v3.x = s / v1.x ;
		v3.y = s / v1.y ;
		v3.z = s / v1.z ;
		v3.w = s / v1.w ;
		return v3;
	}
}