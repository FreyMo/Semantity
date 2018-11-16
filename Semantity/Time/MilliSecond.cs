namespace Semantity
{
	using Definitions;

	public class MilliSecond : Unit<Time>
	{
		public static MilliSecond Instance { get; } = new MilliSecond();

		public override string Symbol => "ms";

		public override double FactorToBaseUnit => 1.0e-3;
	}
}