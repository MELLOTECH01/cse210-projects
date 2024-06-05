using System;
using System.Linq;
using System.Collections.Generic;


// Circle class derived from Shape
class Circle : Shape
{
	private double _radius;

	public Circle(string color, double radius) : base(color)
	{
		_radius = radius;
	}

	public override double GetArea()
	{
		return Math.PI * _radius * _radius;
	}
}
