namespace Semantity.LengthQuantity
{
	using Definitions;

	public sealed class MicroMeter : Unit<Length>
	{
		public static MicroMeter Instance { get; } = new MicroMeter();

		public override string Symbol => "µm";

		public override double FactorToBaseUnit => 1.0e-6;
	}
}