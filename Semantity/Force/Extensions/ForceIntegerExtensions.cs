namespace Semantity
{
	using System;

	public static class ForceIntegerExtensions
	{
		public static Force Newton(this int value)
		{
			return Convert.ToDouble(value).Newton();
		}
	}
}