namespace Semantity.LengthQuantity.Extensions
{
	using System;

	public static class IntegerExtensions
	{
		public static Length MilliMeters(this int value)
		{
			return Convert.ToDouble(value).MilliMeters();
		}

		public static Length MicroMeters(this int value)
		{
			return Convert.ToDouble(value).MicroMeters();
		}

		public static Length NanoMeters(this int value)
		{
			return Convert.ToDouble(value).NanoMeters();
		}

		public static Length Meters(this int value)
		{
			return Convert.ToDouble(value).Meters();
		}

		public static Length Inches(this int value)
		{
			return Convert.ToDouble(value).Inches();
		}
	}
}