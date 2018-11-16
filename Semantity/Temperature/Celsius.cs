namespace Semantity
{
	using Definitions;

	public class Celsius : BaseUnit<Temperature>
	{
		public static Celsius Instance { get; } = new Celsius();

		public override string Symbol => "°C";
	}
}