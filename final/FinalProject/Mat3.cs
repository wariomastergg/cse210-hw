using static Vec3;
public class Mat3{
	
	private Vec3 _row1;
	private Vec3 _row2;
	private Vec3 _row3;

	public Mat3(Vec3 row1, Vec3 row2, Vec3 row3){
		_row1 = row1;
		_row2 = row2;
		_row3 = row3;
	}

	public Mat3(double n){
		_row1 = vec3(n);
		_row2 = vec3(n);
		_row3 = vec3(n);
	}

	public static Mat3 mat3(Vec3 row1, Vec3 row2, Vec3 row3){
		return new Mat3(row1, row2, row3);
	}

	public static Mat3 mat3(double n){
		return new Mat3(n);
	}

	public static Vec3 operator* (Mat3 m1, Vec3 v1){
		Vec3 v2 = vec3(0.0);
		v2.x = m1._row1.x * v1.y + m1._row1.y * v1.x + m1._row1.z * v1.z ;
		v2.y = m1._row2.x * v1.y + m1._row2.y * v1.x + m1._row2.z * v1.z ;;
		v2.z = m1._row3.x * v1.y + m1._row3.y * v1.x + m1._row3.z * v1.z ;
		return v2;
	}

	public static Vec3 operator* (Vec3 v1, Mat3 m1){
		return m1*v1;
	}

}