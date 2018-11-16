namespace Semantity
{
	using System;

	public static class TemperatureIntegerExtensions
	{
		public static Temperature DegreesCelsius(this int value)
		{
			return Convert.ToDouble(value).DegreesCelsius();
		}
	}
}