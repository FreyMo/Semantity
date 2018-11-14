namespace Semantity.Util.Predicates
{
	using System;

	internal static class ComparablePredicates
	{
		public static bool IsEqualTo<T>(this T source, T target) where T : IComparable
		{
			return source.CompareTo(target) == 0;
		}

		public static bool IsLessThan<T>(this T source, T target) where T : IComparable
		{
			return source.CompareTo(target) < 0;
		}

		public static bool IsLessOrEqual<T>(this T source, T target) where T : IComparable
		{
			return source.IsLessThan(target) || source.IsEqualTo(target);
		}
	}
}