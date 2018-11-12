namespace Semantity.PowerQuantity.Extensions
{
	public static class PowerDoubleExtensions
	{
		public static Power Watts(this double value)
		{
			return new Power(value, Watt.Instance);
		}
	}
}