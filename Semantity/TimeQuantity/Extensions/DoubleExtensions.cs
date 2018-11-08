namespace Semantity.TimeQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Time Seconds(this double value)
		{
			return new Time(value, Second.Instance);
		}

		public static Time MilliSeconds(this double value)
		{
			return new Time(value, MilliSecond.Instance);
		}

		public static Time NanoSeconds(this double value)
		{
			return new Time(value, NanoSecond.Instance);
		}

		public static Time PicoSeconds(this double value)
		{
			return new Time(value, PicoSecond.Instance);
		}
	}
}