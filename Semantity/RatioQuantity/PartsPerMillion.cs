namespace Semantity.RatioQuantity
{
	using Definitions;

	public class PartsPerMillion : Unit<Ratio>
	{
		public override string Symbol => "ppm";

		public override double FactorToBaseUnit => 1.0e-6;
	}
}