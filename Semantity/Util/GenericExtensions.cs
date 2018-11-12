namespace Semantity.Extensions
{
	using System.Collections.Generic;

	public static class GenericExtensions
	{
		public static bool EqualityEquals<T>(this T source, T target)
		{
			return EqualityComparer<T>.Default.Equals(source, target);
		}
	}
}