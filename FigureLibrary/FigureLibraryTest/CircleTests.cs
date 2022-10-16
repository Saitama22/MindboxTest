using System;
using System.Collections.Generic;
using FigureLibrary.Figures;
using NUnit.Framework;

namespace FigureLibraryTest
{
	class CircleTests : FigureTest
	{
		private Dictionary<Circle, double> CirclesAreas = new()
		{
			{ new Circle(3), 9 * Math.PI },
			{ new Circle(4), 16 * Math.PI },
			{ new Circle(1), Math.PI }
		};

		private List<Lazy<Circle>> NonExistentCircles = new()
		{
			new Lazy<Circle>(() => new Circle(-1)),
		};

		[Test]
		public void CheckCirclesAreas() => CheckEquals(CirclesAreas);

		[Test]
		public void CheckNonExistentCircles() => CheckNonExistentFigure(NonExistentCircles);
	}
}
