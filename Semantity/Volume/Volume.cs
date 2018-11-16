namespace Semantity
{
	using Definitions;
	using Util.ArgumentMust;

	public class Volume : PhysicalQuantity<Volume>
	{
		public Volume() : this(default(double))
		{
		}

		public Volume(double value) : base(value, CubicMeter.Instance)
		{
		}

		public Volume(double value, Unit<Volume> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Volume> BaseUnit => CubicMeter.Instance;

		public static Area operator /(Volume leftHandSide, Length rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Area(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}

		public static Length operator /(Volume leftHandSide, Area rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Length(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}