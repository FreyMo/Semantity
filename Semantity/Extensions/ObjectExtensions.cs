namespace Semantity.Extensions
{
	using System;
	using System.Linq;
	using ArgumentMust;

	public static class ObjectExtensions
	{
		public static T As<T>(this object obj) where T : class
		{
			return obj as T;
		}

		public static T Cast<T>(this object obj)
		{
			return (T)obj;
		}

		public static bool Is<T>(this object obj)
		{
			return obj is T;
		}

		public static void IfIsType<T>(this object obj, Action action)
		{
			ArgumentMust.NotBeNull(() => obj);

			if (obj.Is<T>())
			{
				action();
			}
		}

		public static void IfIsType<T>(this object obj, Action<T> action) where T : class
		{
			ArgumentMust.NotBeNull(() => obj);

			if (obj.Is<T>())
			{
				action(obj.As<T>());
			}
		}

		public static bool CheckForValues(this object source, params object[] expectedValues)
		{
			if (expectedValues == null)
			{
				return source == null;
			}

			return expectedValues.Any(item => expectedValues.Any(value => item.EqualityEquals(source)));
		}
	}
}