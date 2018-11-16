namespace Semantity
{
	using Definitions;

	public sealed class KiloGram : BaseUnit<Mass>
	{
		public static KiloGram Instance { get; } = new KiloGram();

		public override string Symbol => "kg";
	}
}