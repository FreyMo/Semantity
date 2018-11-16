namespace Semantity
{
	public static class VelocityDoubleExtensions
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

		public static Velocity MilesPerHour(this double value)
		{
			return new Velocity(value, MilePerHour.Instance);
		}
	}
}