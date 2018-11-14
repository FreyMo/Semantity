namespace Semantity.MassQuantity
{
	using Definitions;

	public sealed class MilliGram : Unit<Mass>
	{
		public static MilliGram Instance { get; } = new MilliGram();

		public override string Symbol => "mg";

		public override double FactorToBaseUnit => 10e-6;
	}
}