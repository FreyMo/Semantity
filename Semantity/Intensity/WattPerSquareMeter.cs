namespace Semantity
{
	using Definitions;

	public class WattPerSquareMeter : BaseUnit<Intensity>
	{
		public static WattPerSquareMeter Instance { get; } = new WattPerSquareMeter();

		public override string Symbol => "W/m²";
	}
}