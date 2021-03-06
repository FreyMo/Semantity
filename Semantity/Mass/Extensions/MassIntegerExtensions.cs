﻿namespace Semantity
{
	using System;

	public static class MassIntegerExtensions
	{
		public static Mass KiloGrams(this int value)
		{
			return Convert.ToDouble(value).KiloGrams();
		}

		public static Mass Grams(this int value)
		{
			return Convert.ToDouble(value).Grams();
		}

		public static Mass MilliGrams(this int value)
		{
			return Convert.ToDouble(value).MilliGrams();
		}

		public static Mass Tonnes(this int value)
		{
			return Convert.ToDouble(value).Tonnes();
		}
	}
}