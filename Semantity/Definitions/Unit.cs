namespace Semantity.Definitions
{
	public abstract class Unit<TPhysicalQuantity> : IUnit
		where TPhysicalQuantity : IPhysicalQuantity<TPhysicalQuantity>
	{
		public abstract double FactorToBaseUnit { get; }

		public abstract string Symbol { get; }
	}
}