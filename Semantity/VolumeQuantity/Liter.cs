namespace Semantity.VolumeQuantity
{
	using Definitions;

	public sealed class Liter : Unit<Volume>
	{
		public static Liter Instance { get; } = new Liter();

		public override string Symbol => "l";

		public override double FactorToBaseUnit => 10e-3;
	}
}