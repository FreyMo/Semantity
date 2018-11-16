namespace Semantity.Util
{
	using System.Collections.Generic;

	internal static class GenericExtensions
	{
		public static bool EqualityEquals<T>(this T source, T target)
		{
			return EqualityComparer<T>.Default.Equals(source, target);
		}
	}
}