namespace Semantity.FrequencyQuantity.Extensions
{
	public static class FrequencyDoubleExtensions
	{
		public static Frequency Hertz(this double value)
		{
			return new Frequency(value);
		}

		public static Frequency KiloHertz(this double value)
		{
			return new Frequency(value, FrequencyQuantity.KiloHertz.Instance);
		}

		public static Frequency MegaHertz(this double value)
		{
			return new Frequency(value, FrequencyQuantity.MegaHertz.Instance);
		}

		public static Frequency GigaHertz(this double value)
		{
			return new Frequency(value, FrequencyQuantity.GigaHertz.Instance);
		}
	}
}