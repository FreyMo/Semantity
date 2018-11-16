namespace Semantity
{
	using Definitions;

	public sealed class MilliMeter : Unit<Length>
	{
		public static MilliMeter Instance { get; } = new MilliMeter();

		public override string Symbol => "mm";

		public override double FactorToBaseUnit => 1.0e-3;
	}
}