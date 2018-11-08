namespace Semantity.TemperatureQuantity.Extensions
{
	public static class DoubleExtensions
	{
		public static Temperature DegreesCelsius(this double value)
		{
			return new Temperature(value, Celsius.Instance);
		}
	}
}