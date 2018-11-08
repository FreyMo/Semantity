namespace Semantity.FrequencyQuantity
{
	using Definitions;

	public sealed class Hertz : BaseUnit<Frequency>
	{
		public static Hertz Instance { get; } = new Hertz();

		public override string Symbol => "Hz";
	}
}