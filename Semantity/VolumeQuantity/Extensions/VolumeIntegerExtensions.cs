namespace Semantity.VolumeQuantity.Extensions
{
	using System;

	public static class VolumeIntegerExtensions
	{
		public static Volume CubicMeters(this int value)
		{
			return Convert.ToDouble(value).CubicMeters();
		}

		public static Volume Liters(this int value)
		{
			return Convert.ToDouble(value).Liters();
		}

		public static Volume MilliLiters(this int value)
		{
			return Convert.ToDouble(value).MilliLiters();
		}
	}
}