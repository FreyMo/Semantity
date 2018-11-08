namespace Semantity.Definitions
{
	public interface IPhysicalQuantityBase
	{
		double Value { get; }

		string UnitSymbol { get; }
	}
}