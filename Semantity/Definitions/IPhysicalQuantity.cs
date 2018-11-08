namespace Semantity.Definitions
{
	public interface IPhysicalQuantity<TPhysicalQuantity> : IPhysicalQuantityBase
		where TPhysicalQuantity : IPhysicalQuantity<TPhysicalQuantity>
	{
		Unit<TPhysicalQuantity> Unit { get; }
	}
}