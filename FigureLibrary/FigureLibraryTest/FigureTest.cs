using System;
using System.Collections.Generic;
using FigureLibrary.Interfaces;
using NUnit.Framework;

namespace FigureLibraryTest
{
	public abstract class FigureTest
	{
	 	public void CheckEquals<TKey>(IDictionary<TKey, double> dictionary) where TKey : IFigure
		{
			foreach (var item in dictionary)
			{
				Assert.AreEqual(Math.Round(item.Key.FindArea()), Math.Round(item.Value));
			}
		}


		public void CheckNonExistentFigure<T>(List<Lazy<T>> nonExistentFigures) where T : IFigure
		{
			foreach (var nonExistentFigure in nonExistentFigures)
			{
				try
				{
					var figure = nonExistentFigure.Value;
				}
				catch (Exception)
				{
					Assert.Pass();
				}
				Assert.Fail("Не вызвана ошибка при создании несуществующено трегугольника");
			}
		}
	}
}
