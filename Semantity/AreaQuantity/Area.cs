namespace Semantity.AreaQuantity
{
	using ArgumentMust;
	using Definitions;
	using IntensityQuantity;
	using LengthQuantity;
	using PowerQuantity;

	public sealed class Area : PhysicalQuantity<Area>
	{
		public Area() : this(default(double))
		{
		}

		public Area(double value) : this(value, SquareMeter.Instance)
		{
		}

		public Area(double value, Unit<Area> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Area> BaseUnit => SquareMeter.Instance;

		public static Length operator /(Area leftHandSide, Length rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Length(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}

		public static Power operator *(Area leftHandSide, Intensity rightHandSide)
		{
			return rightHandSide * leftHandSide;
		}
	}
}