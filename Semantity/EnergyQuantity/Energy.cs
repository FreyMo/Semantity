namespace Semantity.EnergyQuantity
{
	using Definitions;
	using PowerQuantity;
	using TimeQuantity;
	using Util.ArgumentMust;

	public class Energy : PhysicalQuantity<Energy>
	{
		public Energy() : this(default(double))
		{
		}

		public Energy(double value) : this(value, new Joule())
		{
		}

		public Energy(double value, Unit<Energy> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Energy> BaseUnit => Joule.Instance;

		public static Time operator /(Energy leftHandSide, Power rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Time(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}

		public static Power operator /(Energy leftHandSide, Time rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Power(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}