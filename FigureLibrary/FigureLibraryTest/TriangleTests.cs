using System;
using System.Collections.Generic;
using FigureLibrary.Figures;
using NUnit.Framework;

namespace FigureLibraryTest
{
	public class TriangleTests : FigureTest
	{
		private Dictionary<Triangle, double> TrianglesAreas = new()
		{
			{ new Triangle(3, 4, 5), 6 },
			{ new Triangle(3, 3, 3), 9 * Math.Sqrt(3) / 4 },
			{ new Triangle(3, 1, 3), Math.Sqrt(35) / 4 }
		};

		private List<Lazy<Triangle>> NonExistentTriangles = new()
		{
			new Lazy<Triangle>(() => new Triangle(1, 2, 3)),
			new Lazy<Triangle>(() => new Triangle(-1, 2, 2)),
			new Lazy<Triangle>(() => new Triangle(1, -2, 2)),
			new Lazy<Triangle>(() => new Triangle(1, 2, -2)),
		};

		private Dictionary<Triangle, bool> IsRightTriangles = new()
		{
			{ new Triangle(3, 4, 5), true },
			{ new Triangle(3, 3, 3), false },
		};

		[Test]
		public void CheckTrianglesAreas() => CheckEquals(TrianglesAreas);

		[Test]
		public void CheckNonExistentTriangles() => CheckNonExistentFigure(NonExistentTriangles);

		[Test]
		public void CheckIsRightTriangles()
		{
			foreach (var rightTriangle in IsRightTriangles)
			{
				Assert.AreEqual(rightTriangle.Key.IsRightTriangle(), rightTriangle.Value);
			}
		}
	}
}