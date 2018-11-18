namespace Semantity
{
	using Definitions;

	public sealed class Tonne : Unit<Mass>
	{
		public static Tonne Instance { get; } = new Tonne();

		public override string Symbol => "t";

		public override double FactorToBaseUnit => 10e3;
	}
}