namespace Semantity
{
	using Definitions;
	using Util.ArgumentMust;

	public class Acceleration : PhysicalQuantity<Acceleration>
	{
		public Acceleration() : this(default(double))
		{
		}

		public Acceleration(double value) : base(value, MeterPerSecondSquared.Instance)
		{
		}

		public Acceleration(double value, Unit<Acceleration> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Acceleration> BaseUnit => MeterPerSecondSquared.Instance;

		public static Velocity operator *(Acceleration leftHandSide, Time rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Velocity(leftHandSide.ValueInBaseUnit * rightHandSide.ValueInBaseUnit);
		}
	}
}