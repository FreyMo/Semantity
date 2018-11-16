namespace Semantity
{
	using Definitions;

	public sealed class KiloGramPerCubicMeter : BaseUnit<Density>
	{
		public static KiloGramPerCubicMeter Instance { get; } = new KiloGramPerCubicMeter();

		public override string Symbol => "kg/m³";
	}
}