namespace Semantity
{
	using Definitions;
	using Util.ArgumentMust;

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

		public static Density operator /(Mass leftHandSide, Volume rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Density(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}