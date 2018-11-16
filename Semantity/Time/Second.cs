namespace Semantity
{
	using Definitions;

	public class Second : BaseUnit<Time>
	{
		public static Second Instance { get; } = new Second();

		public override string Symbol => "s";
	}
}