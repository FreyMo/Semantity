namespace Semantity.MassQuantity
{
	using Definitions;

	public sealed class Gram : Unit<Mass>
	{
		public static Gram Instance { get; } = new Gram();

		public override string Symbol => "g";

		public override double FactorToBaseUnit => 10e-3;
	}
}