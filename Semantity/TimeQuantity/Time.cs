namespace Semantity.TimeQuantity
{
	using Definitions;
	using EnergyQuantity;
	using PowerQuantity;

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
			return rightHandSide * leftHandSide;
		}
	}
}