namespace Semantity.TimeQuantity
{
	using Definitions;

	public class PicoSecond : Unit<Time>
	{
		public static PicoSecond Instance { get; } = new PicoSecond();

		public override string Symbol => "ps";

		public override double FactorToBaseUnit => 1.0e-12;
	}
}