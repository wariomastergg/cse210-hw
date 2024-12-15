using System;
using System.Numerics;
using System.Diagnostics;
using Raylib_cs;

using static Useful;

using static Vec2;
using static Vec4;
using static Vec3;
using static Mat3;

public class Ray{

    private Vec3[] vert = {
        vec3( 1.0, 1.0, 1.0 ),
        vec3( -1.0, 1.0, 1.0 ),
        vec3( -1.0, -1.0, 1.0 ),
        vec3( 1.0, -1.0, 1.0 ),
        vec3( 1.0, 1.0, -1.0 ),
        vec3( -1.0, 1.0, -1.0 ),
        vec3( -1.0, -1.0, -1.0 ),
        vec3( 1.0, -1.0, -1.0 ),
    };

    private int[,] lines = {
        { 0, 1 },
        { 1, 2 },
        { 2, 3 },
        { 3, 0 },

        { 4, 5 },
        { 5, 6 },
        { 6, 7 },
        { 7, 4 },

        { 0, 4 },
        { 1, 5 },
        { 2, 6 },
        { 3, 7 },
    };

	public Vec3 Rotx(Vec3 v, double ang){
		Mat3 mat = mat3(
			vec3( 1, 0, 0),
			vec3( 0, Math.Cos(ang), -Math.Sin(ang)),
			vec3( 0, Math.Sin(ang), Math.Cos(ang))
			);
		return mat * v;
	}
	public Vec3 Roty(Vec3 v, double ang){
		Mat3 mat = mat3(
			vec3( Math.Cos(ang), 0, Math.Sin(ang)),
			vec3( 0, 1, 0),
			vec3( -Math.Sin(ang), 0, Math.Cos(ang))
			);
		return mat * v;
	}
	public Vec3 Rotz(Vec3 v, double ang){
		Mat3 mat = mat3(
			vec3( Math.Cos(ang), -Math.Sin(ang), 0),
			vec3( Math.Sin(ang), Math.Cos(ang), 0),
			vec3( 0, 0, 1)
			);
		return mat * v;
	}


	public Ray(){

		int w = 800;
        int h = 480;
        Vec2 m = vec2(0.0);
        Vec2 mv = vec2(0.0);
        Raylib.InitWindow(w, h, "ray");

        Stopwatch stopwatch = new Stopwatch();
        //Shape shp = new Shape();
        double elapsed_time;

        Vec3 view = vec3( 10.0, 0.0, 0.0 );


        while (!Raylib.WindowShouldClose())
        {
            //stopwatch.Start();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            for (int i = 0; i < 12; i++){
                Vec3 p1 = vert[lines[i, 0]];
                Vec3 p2 = vert[lines[i, 1]];

                p1 = (p1*50.0) ;//+ vec3(100.0);
                p1 = (p1*50.0) ;//+ vec3(100.0);

                Raylib.DrawLine((int)Math.Round(p1.x)+(w/2) , (int)Math.Round(p1.y)+(h/2) , (int)Math.Round(p2.x)+(w/2) , (int)Math.Round(p2.y)+(h/2) , Color.Black);
            }

            
            
            
            Raylib.EndDrawing();

            //stopwatch.Stop();
            //elapsed_time = (double)stopwatch.ElapsedMilliseconds;
            //if (elapsed_time < (1000.0 / 60.0)){
//
            //    Thread.Sleep( (int)( (1000.0 / 60.0)-elapsed_time ) );
            //}
        }

        Raylib.CloseWindow();
	}
}