namespace Semantity
{
	using System;

	public static class IntensityIntegerExtensions
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