namespace Semantity.MemoryQuantity.Extensions
{
	public static class MemoryDoubleExtensions
	{
		public static Memory Bytes(this double value)
		{
			return new Memory(value, MemoryQuantity.Bytes.Instance);
		}

		public static Memory KibiBytes(this double value)
		{
			return new Memory(value, KibiByte.Instance);
		}

		public static Memory MebiBytes(this double value)
		{
			return new Memory(value, MebiByte.Instance);
		}

		public static Memory GibiBytes(this double value)
		{
			return new Memory(value, GibiByte.Instance);
		}
	}
}