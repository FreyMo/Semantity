namespace Semantity.PowerQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Power Watts(this double value)
		{
			return new Power(value, Watt.Instance);
		}

		//public static Length _<TUnit>(this int value) where TUnit : Unit<Length>, new()
		//{
		//	return Convert.ToDouble(value)._<TUnit>();
		//}
	}
}