namespace Semantity.MemoryQuantity
{
	using Definitions;

	public sealed class Byte : BaseUnit<Memory>
	{
		public static Byte Instance { get; } = new Byte();

		public override string Symbol => "B";
	}
}