namespace Semantity.VelocityQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Velocity MetersPerSecond(this double value)
		{
			return new Velocity(value, MeterPerSecond.Instance);
		}

		public static Velocity KilometersPerHour(this double value)
		{
			return new Velocity(value, KilometerPerHour.Instance);
		}

		public static Velocity MillimetersPerSecond(this double value)
		{
			return new Velocity(value, MillimeterPerSecond.Instance);
		}
	}
}