namespace Semantity.LengthQuantity
{
	using AreaQuantity;
	using ArgumentMust;
	using Definitions;
	using TimeQuantity;
	using VelocityQuantity;

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

			return new Area(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}