
using static Vec2;

public class Shape{
	double _mass;
	Vec2 _veloicity;
	Vec2 _position;
	Vec2 _gravity;
	double _air_resistance;
	double _framerate;
	bool _grab;
	bool _letgo;
	List<Vec2> _hold;

	void applyForces(){}
	void applyVelocity(){}
	void shapeTrack(){}
	void applyMouse(){}
	void applyCollisions(){}
}