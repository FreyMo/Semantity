namespace Semantity
{
	using System;

	public static class FrequencyIntegerExtensions
	{
		public static Frequency Hertz(this int value)
		{
			return Convert.ToDouble(value).Hertz();
		}

		public static Frequency KiloHertz(this int value)
		{
			return Convert.ToDouble(value).KiloHertz();
		}

		public static Frequency MegaHertz(this int value)
		{
			return Convert.ToDouble(value).MegaHertz();
		}

		public static Frequency GigaHertz(this int value)
		{
			return Convert.ToDouble(value).GigaHertz();
		}
	}
}