namespace Semantity.LengthQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Length MilliMeters(this double value)
		{
			return new Length(value, MilliMeter.Instance);
		}

		public static Length MicroMeters(this double value)
		{
			return new Length(value, MicroMeter.Instance);
		}

		public static Length NanoMeters(this double value)
		{
			return new Length(value, NanoMeter.Instance);
		}

		public static Length Meters(this double value)
		{
			return new Length(value, Meter.Instance);
		}

		public static Length Inches(this double value)
		{
			return new Length(value, Inch.Instance);
		}
	}
}