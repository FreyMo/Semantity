﻿namespace Semantity
{
	using System;

	public static class AccelerationIntegerExtensions
	{
		public static Acceleration MetersPerSecondSquared(this int value)
		{
			return Convert.ToDouble(value).MetersPerSecondSquared();
		}
	}
}