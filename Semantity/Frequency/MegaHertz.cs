namespace Semantity
{
	using Definitions;

	public sealed class MegaHertz : Unit<Frequency>
	{
		public static MegaHertz Instance { get; } = new MegaHertz();

		public override string Symbol => "MHz";

		public override double FactorToBaseUnit => 1.0e6;
	}
}