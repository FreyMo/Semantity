namespace Semantity
{
	using Definitions;

	public sealed class MeterPerSecond : BaseUnit<Velocity>
	{
		public static MeterPerSecond Instance { get; } = new MeterPerSecond();

		public override string Symbol => "m/s";
	}
}