namespace Semantity
{
	using Definitions;
	using Util.ArgumentMust;

	public class Force : PhysicalQuantity<Force>
	{
		public Force() : this(default(double))
		{
		}

		public Force(double value) : base(value, Newton.Instance)
		{
		}

		public Force(double value, Unit<Force> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Force> BaseUnit => Newton.Instance;

		public static Mass operator /(Force leftHandSide, Acceleration rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Mass(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}


		public static Acceleration operator /(Force leftHandSide, Mass rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Acceleration(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}