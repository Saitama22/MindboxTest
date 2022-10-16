using System;

namespace FigureLibrary.Helpers
{
	internal static class NumberHelper
	{
		/// <summary>
		/// Проверка на положительное значение, выброс исключение, если число отрицательное
		/// </summary>
		/// <param name="number"></param>
		/// <returns>Исходное значение</returns>
		/// <exception cref="Exception"></exception>
		internal static double CheckPositive(this double number)
		{
			if (number < 0)
				throw new Exception("Параметр не может быть меньше 0");
			return number;
		}
	}
}
