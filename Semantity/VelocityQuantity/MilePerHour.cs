namespace Semantity.VelocityQuantity
{
	using Definitions;

	public sealed class MilePerHour : Unit<Velocity>
	{
		public static MilePerHour Instance { get; } = new MilePerHour();

		public override string Symbol => "mph";

		public override double FactorToBaseUnit => 2.23694;
	}
}