namespace Semantity.RatioQuantity
{
	using Definitions;

	public class Percent : Unit<Ratio>
	{
		public static Percent Instance { get; } = new Percent();

		public override string Symbol => "%";

		public override double FactorToBaseUnit => 1.0e-2;
	}
}