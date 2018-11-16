namespace Semantity.AccelerationQuantity.Extensions
{
	public static class AccelerationDoubleExtensions
	{
		public static Acceleration MetersPerSecondSquared(this double value)
		{
			return new Acceleration(value, MeterPerSecondSquared.Instance);
		}
	}
}