using System;
using FigureLibrary.Helpers;
using FigureLibrary.Interfaces;

namespace FigureLibrary.Figures
{
	/// <summary>
	/// Класс круга, радиус извне изменить нельзя, тк это был бы другой круг
	/// </summary>
	public class Circle : IFigure
	{
		private double _radius;

		public Circle(double radius)
		{
			Radius = radius;
		}

		public double Radius 
		{ 
			get => _radius;
			private set => _radius = value.CheckPositive();
		}

		public double FindArea()
		{
			return Math.Pow(Radius, 2) * Math.PI;
		}

		public static double FindArea(double radius)
		{
			var circle = new Circle(radius);
			return circle.FindArea();
		}
	}
}
