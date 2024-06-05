using System;
using System.Linq;
using System.Collections.Generic;


// Base class Shape
abstract class Shape
{
	protected string _color;

	public Shape(string color)
	{
		_color = color;
	}

	public string GetColor()
	{
		return _color;
	}

	public void SetColor(string color)
	{
		_color = color;
	}

	public abstract double GetArea();
}
