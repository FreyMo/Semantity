namespace Semantity.AreaQuantity
{
	using Definitions;

	public sealed class SquareCentiMeter : Unit<Area>
	{
		public static SquareCentiMeter Instance { get; } = new SquareCentiMeter();

		public override string Symbol => "cm²";

		public override double FactorToBaseUnit => 1.0e-4;
	}
}