namespace Semantity
{
	using Definitions;

	public class Density : PhysicalQuantity<Density>
	{
		public Density() : this(default(double))
		{
		}

		public Density(double value) : base(value, KiloGramPerCubicMeter.Instance)
		{
		}

		public Density(double value, Unit<Density> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Density> BaseUnit => KiloGramPerCubicMeter.Instance;
	}
}