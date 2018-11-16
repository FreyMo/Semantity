namespace Semantity
{
	using Definitions;

	public sealed class KiloHertz : Unit<Frequency>
	{
		public static KiloHertz Instance { get; } = new KiloHertz();

		public override string Symbol => "kHz";

		public override double FactorToBaseUnit => 1.0e3;
	}
}