namespace Semantity.AreaQuantity
{
	using Definitions;

	public sealed class SquareKiloMeter : Unit<Area>
	{
		public static SquareKiloMeter Instance { get; } = new SquareKiloMeter();

		public override double FactorToBaseUnit => 1.0e6;

		public override string Symbol => "km²";
	}
}