namespace Semantity
{
	using Definitions;

	public sealed class KilometerPerHour : Unit<Velocity>
	{
		public static KilometerPerHour Instance { get; } = new KilometerPerHour();

		public override string Symbol => "km/h";

		public override double FactorToBaseUnit => 3.6;
	}
}