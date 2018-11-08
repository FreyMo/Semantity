namespace Semantity.TimeQuantity.Extensions
{
	using System;

	public static class IntegerExtensions
	{
		public static Time Seconds(this int value)
		{
			return Convert.ToDouble(value).Seconds();
		}

		public static Time MilliSeconds(this int value)
		{
			return Convert.ToDouble(value).MilliSeconds();
		}

		public static Time NanoSeconds(this int value)
		{
			return Convert.ToDouble(value).NanoSeconds();
		}

		public static Time PicoSeconds(this int value)
		{
			return Convert.ToDouble(value).PicoSeconds();
		}
	}
}