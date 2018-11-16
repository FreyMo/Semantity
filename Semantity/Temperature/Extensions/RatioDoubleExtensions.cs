namespace Semantity
{
	public static class RatioDoubleExtensions
	{
		public static Temperature DegreesCelsius(this double value)
		{
			return new Temperature(value, Celsius.Instance);
		}
	}
}