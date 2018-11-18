namespace Semantity
{
	using Definitions;

	public sealed class Newton : BaseUnit<Force>
	{
		public static Newton Instance { get; } = new Newton();

		public override string Symbol => "N";
	}
}