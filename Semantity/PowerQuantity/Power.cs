namespace Semantity.PowerQuantity
{
	using AreaQuantity;
	using Definitions;
	using EnergyQuantity;
	using IntensityQuantity;
	using TimeQuantity;
	using Util.ArgumentMust;

	public class Power : PhysicalQuantity<Power>
	{
		public Power() : this(default(double))
		{
		}

		public Power(double value) : this(value, Watt.Instance)
		{
		}

		public Power(double value, Unit<Power> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Power> BaseUnit => Watt.Instance;

		public static Energy operator *(Power leftHandSide, Time rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Energy(leftHandSide.ValueInBaseUnit * rightHandSide.ValueInBaseUnit);
		}

		public static Intensity operator /(Power leftHandSide, Area rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Intensity(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}

		public static Area operator /(Power leftHandSide, Intensity rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Area(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}