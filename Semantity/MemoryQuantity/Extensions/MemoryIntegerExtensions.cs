namespace Semantity.MemoryQuantity.Extensions
{
	using System;

	public static class MemoryIntegerExtensions
	{
		public static Memory Bytes(this int value)
		{
			return Convert.ToDouble(value).Bytes();
		}

		public static Memory KibiBytes(this int value)
		{
			return Convert.ToDouble(value).KibiBytes();
		}

		public static Memory MebiBytes(this int value)
		{
			return Convert.ToDouble(value).MebiBytes();
		}

		public static Memory GibiBytes(this int value)
		{
			return Convert.ToDouble(value).GibiBytes();
		}
	}
}