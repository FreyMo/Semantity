namespace Semantity.RatioQuantity.Extensions
{
	public static class RatioDoubleExtensions
	{
		public static Ratio Percent(this double value)
		{
			return new Ratio(value, new Percent());
		}

		public static Ratio Permil(this double value)
		{
			return new Ratio(value, new Permil());
		}

		public static Ratio PartsPerMillion(this double value)
		{
			return new Ratio(value, new PartsPerMillion());
		}

		public static Ratio Whole(this double value)
		{
			return new Ratio(value, new Whole());
		}
	}
}