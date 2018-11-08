namespace Semantity.AreaQuantity
{
	using Definitions;

	public sealed class SquareMeter : BaseUnit<Area>
	{
		public static SquareMeter Instance { get; } = new SquareMeter();

		public override string Symbol => "m²";
	}
}