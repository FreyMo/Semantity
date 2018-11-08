namespace Semantity.MemoryQuantity
{
	using Definitions;

	public sealed class GibiByte : Unit<Memory>
	{
		public static GibiByte Instance { get; } = new GibiByte();

		public override double FactorToBaseUnit => 1024 * 1024 * 1024;

		public override string Symbol => "GiB";
	}
}