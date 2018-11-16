namespace Semantity
{
	using Definitions;

	public class NanoSecond : Unit<Time>
	{
		public static NanoSecond Instance { get; } = new NanoSecond();

		public override string Symbol => "ns";

		public override double FactorToBaseUnit => 1.0e-9;
	}
}