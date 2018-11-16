namespace Semantity
{
	using Definitions;

	public class Mass : PhysicalQuantity<Mass>
	{
		public Mass() : this(default(double))
		{
		}

		public Mass(double value) : base(value, KiloGram.Instance)
		{
		}

		public Mass(double value, Unit<Mass> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Mass> BaseUnit => KiloGram.Instance;
	}
}