namespace Semantity
{
	using System;

	public static class PowerIntegerExtensions
	{
		public static Power Watts(this int value)
		{
			return Convert.ToDouble(value).Watts();
		}
	}
}