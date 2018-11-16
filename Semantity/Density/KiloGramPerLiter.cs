namespace Semantity
{
	using Definitions;

	public sealed class KiloGramPerLiter : Unit<Density>
	{
		public static KiloGramPerLiter Instance { get; } = new KiloGramPerLiter();

		public override double FactorToBaseUnit => 1.0e3;

		public override string Symbol => "kg/l";
	}
}