namespace Semantity.VelocityQuantity
{
	using Definitions;

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
	}
}