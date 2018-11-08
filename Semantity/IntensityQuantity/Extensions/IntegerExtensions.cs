namespace Semantity.IntensityQuantity.Extensions
{
	using System;

	public static class IntegerExtensions
	{
		public static Intensity WattsPerSquareMeter(this int value)
		{
			return Convert.ToDouble(value).WattsPerSquareMeter();
		}

		public static Intensity WattsPerSquareCentimeter(this int value)
		{
			return Convert.ToDouble(value).WattsPerSquareCentimeter();
		}
	}
}