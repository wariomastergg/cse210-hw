using System;
using static Useful;
using static Vec2;


public class Shape{
	protected double _mass;
	public Vec2 _size;	
	protected Vec2 _velocity;
	public Vec2 _position;
	protected Vec2 _gravity;
	protected double _air_resistance;
	protected double _framerate;
	protected Vec2 _window;
	protected bool _grab;
	protected bool _letgo;
	protected Vec2 _drag;
	protected List<Vec2> _hold;

	public Shape(int w, int h){
		_mass = 1.0;
		_size = vec2(100.0);
		_velocity = vec2(0.0);
		_position = vec2( 10.0, 10.0);
		_gravity = vec2( 0.0, 0.089810);
		_air_resistance = -0.00081;
		_framerate = 60.0;
		_window = vec2((double)w, (double)h);
		_grab = false;
		_letgo = false;
		_drag = vec2(0.0);
		_hold = new(){ vec2(0.0), vec2(0.0),vec2(0.0) };
	}

	public void applyForces(){
		//velocity
		_velocity = _velocity + (_velocity * _air_resistance);

		//gravity
		_velocity = _velocity + _gravity;
	}

	public void applyVelocity(){
		_position = _position + ( _velocity / _framerate );	
	}

	public void applyBounderies(){
		Vec2 wallx = Clamp( _position.x , 0.0, _window.x-_size.x);
		Vec2 wally = Clamp( _position.y , 0.0, _window.y-_size.y);
		//Console.WriteLine(wally.y);
		if (wallx.y == 1.0){_velocity.x = -1.0*_velocity.x;}
		if (wally.y == 1.0){_velocity.y = -1.0*_velocity.y; }

		_position = vec2( wallx.x, wally.x );
	}

	public void shapeTrack(Vec2 mousepos, bool clicking){
		if (!_grab){
			if (_letgo){
				_letgo = false;
			}
		}
		if (!clicking){
			if (_grab){
				_letgo = true; 
			}
			_grab = false;
		}
		if (Within(mousepos, _position, _size )){
			if (clicking && !_grab){
				_grab = true;
				_hold[0] = mousepos;
				_hold[1] = mousepos;
				_hold[2] = _position;
			}
		}
		if (_grab){
			_hold[1] = mousepos;
		}
		_drag = _hold[2] + (_hold[1] - _hold[0]);
	}

	public void applyMouse(Vec2 mousepos, Vec2 mousevel, bool clicking){
		shapeTrack(mousepos, clicking);
		if (_grab){
			_velocity = vec2(0.0);
			_position = _drag;
		}
		else if (_letgo){
			_velocity = _velocity + (mousevel * 5.0);
		}
	}

	public void applyCollisions(){}
}