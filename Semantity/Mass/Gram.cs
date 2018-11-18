namespace Semantity
{
	using Definitions;

	public sealed class Gram : Unit<Mass>
	{
		public static Gram Instance { get; } = new Gram();

		public override string Symbol => "g";

		public override double FactorToBaseUnit => 10e-3;
	}

	public sealed class Tonne : Unit<Mass>
	{
		public static Tonne Instance { get; } = new Tonne();

		public override string Symbol => "t";

		public override double FactorToBaseUnit => 10e3;
	}
}