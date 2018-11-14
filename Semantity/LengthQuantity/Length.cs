namespace Semantity.LengthQuantity
{
	using AreaQuantity;
	using Definitions;
	using TimeQuantity;
	using Util.ArgumentMust;
	using VelocityQuantity;
	using VolumeQuantity;

	public sealed class Length : PhysicalQuantity<Length>
	{
		public Length() : this(default(double))
		{
		}

		public Length(double value) : this(value, Meter.Instance)
		{
		}

		public Length(double value, Unit<Length> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Length> BaseUnit => Meter.Instance;

		public static Velocity operator /(Length leftHandSide, Time rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Velocity(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}

		public static Area operator *(Length leftHandSide, Length rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Area(leftHandSide.ValueInBaseUnit * rightHandSide.ValueInBaseUnit);
		}

		public static Volume operator *(Length leftHandSide, Area rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return rightHandSide * leftHandSide;
		}
	}
}