namespace Semantity.TimeQuantity
{
	using Definitions;

	public class Second : BaseUnit<Time>
	{
		public static Second Instance { get; } = new Second();

		public override string Symbol => "s";
	}
}