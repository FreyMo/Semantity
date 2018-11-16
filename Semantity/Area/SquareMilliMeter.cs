namespace Semantity
{
	using Definitions;

	public sealed class SquareMilliMeter : Unit<Area>
	{
		public static SquareMilliMeter Instance { get; } = new SquareMilliMeter();

		public override string Symbol => "mm²";

		public override double FactorToBaseUnit => 1.0e-6;
	}
}