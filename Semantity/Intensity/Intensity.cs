namespace Semantity
{
	using Definitions;
	using Util.ArgumentMust;

	public class Intensity : PhysicalQuantity<Intensity>
	{
		public Intensity() : this(default(double))
		{
		}

		public Intensity(double value) : base(value, WattPerSquareMeter.Instance)
		{
		}

		public Intensity(double value, Unit<Intensity> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Intensity> BaseUnit => WattPerSquareMeter.Instance;

		public static Power operator *(Intensity leftHandSide, Area rightHandSide)
		{
			ArgumentMust.NotBeNull(() => leftHandSide);
			ArgumentMust.NotBeNull(() => rightHandSide);

			return new Power(leftHandSide.ValueInBaseUnit / rightHandSide.ValueInBaseUnit);
		}
	}
}