namespace Semantity.RatioQuantity.Extensions
{
	using System;

	public static class RatioIntegerExtensions
	{
		public static Ratio Percent(this int value)
		{
			return Convert.ToDouble(value).Percent();
		}

		public static Ratio Permil(this int value)
		{
			return Convert.ToDouble(value).Permil();
		}

		public static Ratio PartsPerMillion(this int value)
		{
			return Convert.ToDouble(value).PartsPerMillion();
		}

		public static Ratio Whole(this int value)
		{
			return Convert.ToDouble(value).Whole();
		}
	}
}