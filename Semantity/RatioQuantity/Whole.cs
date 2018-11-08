namespace Semantity.RatioQuantity
{
	using Definitions;

	public class Whole : BaseUnit<Ratio>
	{
		public static Whole Instance { get; } = new Whole();

		public override string Symbol => string.Empty;
	}
}