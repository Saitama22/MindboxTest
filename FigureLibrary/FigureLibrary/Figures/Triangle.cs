using System;
using System.Linq;
using FigureLibrary.Helpers;
using FigureLibrary.Interfaces;

namespace FigureLibrary.Figures
{
	/// <summary>
	/// Класс треугольника, стороны изменить извне нельзя, тк это был бы другой треугольник
	/// </summary>
	public class Triangle : IFigure
	{
		private double _a;
		private double _b;
		private double _c;
		private double[] _sidesOrderly;

		public Triangle(double a, double b, double c)
		{
			A = a;
			B = b;
			C = c;
			var sides = SidesOrderly;
			if (sides[0] >= sides[1] + sides[2])
				throw new Exception("Такого треугольника не существует");
		}

		public double A { get => _a; private set => _a = value.CheckPositive(); }
		public double B { get => _b; private set => _b = value.CheckPositive(); }
		public double C { get => _c; private set => _c = value.CheckPositive(); }		

		private double FindPerimeter()
		{
			return A + B + C;
		}

		/// <summary>
		/// Cтороны по убыванию.
		/// </summary>
		/// <returns></returns>
		private double[] SidesOrderly => _sidesOrderly ??= new[] { A, B, C }.OrderByDescending(side => side).ToArray();

		public double FindArea()
		{
			var semiPerimeter = FindPerimeter() / 2;
			return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));			
		}

		public static double FindArea(double a, double b, double c)
		{
			var triangle = new Triangle(a, b, c);
			return triangle.FindArea();
		}		

		public bool IsRightTriangle()
		{
			var sides = SidesOrderly;
			
			if (Math.Pow(sides[0], 2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))
				return true;
			return false;
		}
	}
}
