namespace Semantity
{
	using Definitions;

	public sealed class MilliLiter : Unit<Volume>
	{
		public static MilliLiter Instance { get; } = new MilliLiter();

		public override string Symbol => "ml";

		public override double FactorToBaseUnit => 10e-6;
	}
}