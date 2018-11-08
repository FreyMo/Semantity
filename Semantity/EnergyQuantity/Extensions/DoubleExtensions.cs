namespace Semantity.EnergyQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Energy Joules(this double value)
		{
			return new Energy(value);
		}

		public static Energy MilliJoules(this double value)
		{
			return new Energy(value, MilliJoule.Instance);
		}
	}
}