using System;
using static Vector;

public class Vec3 : Vector{

	//CONSTRUCTOR STUFF
	public Vec3( double X, double Y, double Z ){
		x = X;
		y = Y;
		z = Z;
	}

	public Vec3( double n ){
		x = n;
		y = n;
		z = n;
	}

	//a thing for making a vector 2 without needing new
	//mainly just for writing code faster
	public static Vec3 vec3(double X, double Y, double Z){
		return new Vec3(X,Y,Z);
	}
	public static Vec3 vec3( double n ){
		return new Vec3(n);
	}

	//GETTER STUFF
	public double X(){ return x; }
	public double Y(){ return y; }
	public double Z(){ return y; }

	//SETTER STUFF
	public void X( double X ){ x = X; }
	public void Y( double Y ){ y = Y; }
	public void Z( double X ){ x = X; }
	

	//OPERATOR STUFF

	//add
	public static Vec3 operator+ (Vec3 v1, Vec3 v2){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x + v2.x ;
		v3.y = v1.y + v2.y ;
		v3.z = v1.z + v2.z ;
		return v3;
	}

	//subtract
	public static Vec3 operator- (Vec3 v1, Vec3 v2){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x - v2.x ;
		v3.y = v1.y - v2.y ;
		v3.z = v1.z - v2.z ;
		return v3;
	}

	//multiply
	public static Vec3 operator* (Vec3 v1, Vec3 v2){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x * v2.x ;
		v3.y = v1.y * v2.y ;
		v3.z = v1.z * v2.z ;
		return v3;
	}
	public static Vec3 operator* (Vec3 v1, double s){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x * s ;
		v3.y = v1.y * s ;
		v3.z = v1.z * s ;
		return v3;
	}
	public static Vec3 operator* (double s, Vec3 v1){
		Vec3 v3 = vec3(0.0);
		v3 = v3 * s;
		return v3;
	}

	//devide
	public static Vec3 operator/ (Vec3 v1, Vec3 v2){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x / v2.x ;
		v3.y = v1.y / v2.y ;
		v3.z = v1.z / v2.z ;
		return v3;
	}
	public static Vec3 operator/ (Vec3 v1, double s){
		Vec3 v3 = vec3(0.0);
		v3.x = v1.x / s ;
		v3.y = v1.y / s ;
		v3.z = v1.z / s ;
		return v3;
	}
	public static Vec3 operator/ (double s, Vec3 v1){
		Vec3 v3 = vec3(0.0);
		v3.x = s / v1.x ;
		v3.y = s / v1.y ;
		v3.z = s / v1.z ;
		return v3;
	}
}