namespace Semantity.VolumeQuantity.Extensions
{
	public static class VolumeDoubleExtensions
	{
		public static Volume CubicMeters(this double value)
		{
			return new Volume(value, CubicMeter.Instance);
		}

		public static Volume Liters(this double value)
		{
			return new Volume(value, Liter.Instance);
		}

		public static Volume MilliLiters(this double value)
		{
			return new Volume(value, MilliLiter.Instance);
		}
	}
}