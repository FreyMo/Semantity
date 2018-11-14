namespace Semantity.Util.Predicates
{
	internal static class GenericTypePredicates
	{
		public static bool IsNull<T>(this T obj) where T : class
		{
			return obj == null;
		}
	}
}