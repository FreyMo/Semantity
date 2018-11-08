namespace Semantity.PowerQuantity.Extensions
{
	using System;

	public static class IntegerExtensions
	{
		public static Power Watts(this int value)
		{
			return Convert.ToDouble(value).Watts();
		}

		//public static Length _<TUnit>(this int value) where TUnit : Unit<Length>, new()
		//{
		//	return Convert.ToDouble(value)._<TUnit>();
		//}
	}
}