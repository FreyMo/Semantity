namespace Semantity
{
	using Definitions;

	public class Permil : Unit<Ratio>
	{
		public override string Symbol => "‰";

		public override double FactorToBaseUnit => 1.0e-3;
	}
}