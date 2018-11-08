namespace Semantity.PowerQuantity
{
	using Definitions;

	public sealed class Watt : BaseUnit<Power>
	{
		public static Watt Instance { get; } = new Watt();

		public override string Symbol => "W";
	}
}