namespace Semantity.IntensityQuantity
{
	using Definitions;

	public class WattPerSquareCentimeter : Unit<Intensity>
	{
		public static WattPerSquareCentimeter Instance { get; } = new WattPerSquareCentimeter();

		public override string Symbol => "W/cm²";

		public override double FactorToBaseUnit => 1.0e4;
	}
}