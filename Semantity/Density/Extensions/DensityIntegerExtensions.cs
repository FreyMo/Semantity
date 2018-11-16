namespace Semantity
{
	using System;

	public static class DensityIntegerExtensions
	{
		public static Density KiloGramsPerCubicMeter(this int value)
		{
			return Convert.ToDouble(value).KiloGramsPerCubicMeter();
		}

		public static Density GramsPerCubicCentiMeter(this int value)
		{
			return Convert.ToDouble(value).GramsPerCubicCentiMeter();
		}

		public static Density KiloGramsPerLiter(this int value)
		{
			return Convert.ToDouble(value).KiloGramsPerLiter();
		}
	}
}