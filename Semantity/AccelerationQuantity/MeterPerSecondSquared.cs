namespace Semantity.AccelerationQuantity
{
	using Definitions;

	public sealed class MeterPerSecondSquared : BaseUnit<Acceleration>
	{
		public static MeterPerSecondSquared Instance { get; } = new MeterPerSecondSquared();

		public override string Symbol => "m/s²";
	}
}