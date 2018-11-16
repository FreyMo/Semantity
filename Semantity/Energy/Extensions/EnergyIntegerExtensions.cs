namespace Semantity
{
	using System;

	public static class EnergyIntegerExtensions
	{
		public static Energy Joules(this int value)
		{
			return Convert.ToDouble(value).Joules();
		}

		public static Energy MilliJoules(this int value)
		{
			return Convert.ToDouble(value).MilliJoules();
		}
	}
}