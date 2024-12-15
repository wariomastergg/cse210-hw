
using static Vec2;
using static Vec4;
using static Vec3;
public class Useful{
	
	public static Vec2 Clamp(double n, double mi, double mx){
		if ( n < mi ){
			return vec2(mi, 1.0);
		}
		if ( n > mx ){
			return vec2(mx, 1.0);
		}
		return vec2(n, 0.0);
	}
	public static Vec4 Clamp(Vec4 v, double mi, double mx){
		Vec4 v1 = vec4(0.0);
		v1.x = Clamp(v.x, mi, mx).x;
		v1.y = Clamp(v.y, mi, mx).x;
		v1.z = Clamp(v.z, mi, mx).x;
		v1.w = Clamp(v.w, mi, mx).x;
		return v1;
	}

	public static bool Within(Vec2 p1, Vec2 b1, Vec2 b2){
		Vec2 b3 = b1+b2;
		if (p1.x < b1.x || p1.y < b1.y){
			return false;
		}
		if (p1.x > b3.x || p1.y > b3.y){
			return false;
		}
		return true;

	}

}