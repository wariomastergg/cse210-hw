using System;
using System.Numerics;
using Raylib_cs;

using System.Diagnostics;

using static Vec2;

public class Phy{
	public Phy(){
		int w = 800;
        int h = 480;
        Vec2 m = vec2(0.0);
        Vec2 mv = vec2(0.0);
        Raylib.InitWindow(w, h, "cube");
        //Raylib.SetConfigFlags();

        Stopwatch stopwatch = new Stopwatch();


        int amt = 10000;
        Vector2[] a = new Vector2[amt];
        for (int i = 0; i < amt; i++){
        	Vector2 c = new Vector2(0,0);
        	a[i] = c;
        }

        List<Vec2> pts = new();
        for (int i = 0; i < amt; i++){
        	pts.Add( vec2(0.0) );
        }


        Shape shp = new Shape(w, h);
        double elapsed_time;

        while (!Raylib.WindowShouldClose())
        {
            stopwatch.Start();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            Vec2 mouse = vec2( (double)Raylib.GetMouseX() , (double)Raylib.GetMouseY() );
            mv = mouse - m;
            m = mouse;

            bool clk = Raylib.IsMouseButtonDown(MouseButton.Left);
            
            shp.applyForces();
            shp.applyMouse(m, mv, clk);
            shp.applyVelocity();
            shp.applyBounderies();
            

            Raylib.DrawRectangle((int)shp._position.x, (int)shp._position.y, (int)shp._size.x, (int)shp._size.y, Color.Black);
            Raylib.DrawLine( 100, 100, ((int)mv.x)+100, ((int)mv.y)+100, Color.Black);

            pts.RemoveAt(0);
            pts.Add(shp._position+(shp._size/2.0));
            

            for (int i = 0; i < amt; i++){
        		Vector2 c = new Vector2( (int)pts[i].x, (int)pts[i].y );
        		a[i] = c;
        	}
            
            Raylib.DrawLineStrip(a,amt,Color.Green);

            Raylib.EndDrawing();

            stopwatch.Stop();
            elapsed_time = (double)stopwatch.ElapsedMilliseconds;
            if (elapsed_time < (1000.0 / 60.0)){

                Thread.Sleep( (int)( (1000.0 / 60.0)-elapsed_time ) );
            }
        }

        Raylib.CloseWindow();
	}
}