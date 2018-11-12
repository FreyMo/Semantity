namespace Semantity.MemoryQuantity
{
	using Definitions;

	public sealed class Bytes : BaseUnit<Memory>
	{
		public static Bytes Instance { get; } = new Bytes();

		public override string Symbol => "B";
	}
}