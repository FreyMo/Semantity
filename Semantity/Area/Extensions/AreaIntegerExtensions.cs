namespace Semantity
{
	using System;

	public static class AreaIntegerExtensions
	{
		public static Area SquareMeters(this int value)
		{
			return Convert.ToDouble(value).SquareMeters();
		}

		public static Area SquareCentiMeters(this int value)
		{
			return Convert.ToDouble(value).SquareCentiMeters();
		}

		public static Area SquareMilliMeters(this int value)
		{
			return Convert.ToDouble(value).SquareMilliMeters();
		}

		public static Area SquareKiloMeters(this int value)
		{
			return Convert.ToDouble(value).SquareKiloMeters();
		}
	}
}