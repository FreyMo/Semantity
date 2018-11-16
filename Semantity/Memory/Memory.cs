namespace Semantity
{
	using Definitions;

	public class Memory : PhysicalQuantity<Memory>
	{
		public Memory() : this(default(double))
		{
		}

		public Memory(double value) : this(value, Bytes.Instance)
		{
		}

		public Memory(double value, Unit<Memory> unit) : base(value, unit)
		{
		}

		public override BaseUnit<Memory> BaseUnit => Bytes.Instance;
	}
}