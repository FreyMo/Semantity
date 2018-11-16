namespace Semantity
{
	public static class DensityDoubleExtensions
	{
		public static Density KiloGramsPerCubicMeter(this double value)
		{
			return new Density(value, KiloGramPerCubicMeter.Instance);
		}

		public static Density GramsPerCubicCentiMeter(this double value)
		{
			return new Density(value, GramPerCubicCentiMeter.Instance);
		}

		public static Density KiloGramsPerLiter(this double value)
		{
			return new Density(value, KiloGramPerLiter.Instance);
		}
	}
}