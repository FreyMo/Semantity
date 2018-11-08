namespace Semantity.AreaQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Area SquareMeters(this double value)
		{
			return new Area(value, SquareMeter.Instance);
		}

		public static Area SquareCentiMeters(this double value)
		{
			return new Area(value, SquareCentiMeter.Instance);
		}

		public static Area SquareMilliMeters(this double value)
		{
			return new Area(value, SquareMilliMeter.Instance);
		}
	}
}