namespace Semantity.MassQuantity.Extensions
{
	public static class MassDoubleExtensions
	{
		public static Mass KiloGrams(this double value)
		{
			return new Mass(value, KiloGram.Instance);
		}

		public static Mass Grams(this double value)
		{
			return new Mass(value, Gram.Instance);
		}

		public static Mass MilliGrams(this double value)
		{
			return new Mass(value, MilliGram.Instance);
		}
	}
}