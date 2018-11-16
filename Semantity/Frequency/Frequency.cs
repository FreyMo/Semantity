namespace Semantity
{
	using Definitions;

	public class Frequency : PhysicalQuantity<Frequency>
	{
		public Frequency() : this(default(double))
		{
		}

		public Frequency(double value) : this(value, Hertz.Instance)
		{
		}

		public Frequency(double value, Unit<Frequency> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Frequency> BaseUnit => Hertz.Instance;
	}
}