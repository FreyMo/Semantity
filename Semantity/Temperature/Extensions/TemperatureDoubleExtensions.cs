namespace Semantity
{
	public static class TemperatureDoubleExtensions
	{
		public static Temperature DegreesCelsius(this double value)
		{
			return new Temperature(value, Celsius.Instance);
		}
	}
}