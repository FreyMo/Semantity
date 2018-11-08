namespace Semantity.EnergyQuantity
{
	using Definitions;

	public class Joule : BaseUnit<Energy>
	{
		public static Joule Instance { get; } = new Joule();

		public override string Symbol => "J";
	}
}