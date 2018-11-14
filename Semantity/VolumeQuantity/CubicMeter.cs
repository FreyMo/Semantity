namespace Semantity.VolumeQuantity
{
	using Definitions;

	public sealed class CubicMeter : BaseUnit<Volume>
	{
		public static CubicMeter Instance { get; } = new CubicMeter();

		public override string Symbol => "m³";
	}
}