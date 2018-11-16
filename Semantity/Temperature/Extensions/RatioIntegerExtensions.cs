namespace Semantity
{
	using System;

	public static class RatioIntegerExtensions
	{
		public static Temperature DegreesCelsius(this int value)
		{
			return Convert.ToDouble(value).DegreesCelsius();
		}
	}
}