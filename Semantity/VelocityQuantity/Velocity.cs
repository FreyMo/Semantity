namespace Semantity.VelocityQuantity
{
	using AccelerationQuantity;
	using Definitions;
	using TimeQuantity;
	using Util.ArgumentMust;

	public class Velocity : PhysicalQuantity<Velocity>
	{
		public Velocity() : this(default(double))
		{
		}

		public Velocity(double value) : base(value, MeterPerSecond.Instance)
		{
		}

		public Velocity(double value, Unit<Velocity> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Velocity> BaseUnit => MeterPerSecond.Instance;

		public static Acceleration operator /(Velocity leftHandSide, Time rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Acceleration(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}