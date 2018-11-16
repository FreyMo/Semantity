namespace Semantity.TimeQuantity
{
	using AccelerationQuantity;
	using Definitions;
	using EnergyQuantity;
	using PowerQuantity;
	using Util.ArgumentMust;
	using VelocityQuantity;

	public class Time : PhysicalQuantity<Time>
	{
		public Time() : this(default(double))
		{
		}

		public Time(double value) : base(value, Second.Instance)
		{
		}

		public Time(double value, Unit<Time> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Time> BaseUnit => Second.Instance;

		public static Energy operator *(Time leftHandSide, Power rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return rightHandSide * leftHandSide;
		}

		public static Velocity operator *(Time leftHandSide, Acceleration rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return rightHandSide * leftHandSide;
		}
	}
}