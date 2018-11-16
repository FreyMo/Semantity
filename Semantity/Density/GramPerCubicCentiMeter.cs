namespace Semantity
{
	using Definitions;

	public sealed class GramPerCubicCentiMeter : Unit<Density>
	{
		public static GramPerCubicCentiMeter Instance { get; } = new GramPerCubicCentiMeter();

		public override double FactorToBaseUnit => 1.0e3;

		public override string Symbol => "g/cm³";
	}
}