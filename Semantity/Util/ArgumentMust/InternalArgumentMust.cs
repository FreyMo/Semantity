namespace Semantity.Util.ArgumentMust
{
	using System;
	using System.Diagnostics;
	using Predicates;

	internal static class InternalArgumentMust
	{
		[DebuggerHidden]
		public static void NotBeNull<T>(Func<T> argumentFunc) where T : class
		{
			if (argumentFunc().IsNull())
			{
				var nullArgument = argumentFunc.GetParameter(GenericTypePredicates.IsNull);
				throw new ArgumentNullException(nullArgument.Name);
			}
		}

		[DebuggerHidden]
		public static void BeGreater<T>(Func<T> argumentFunc, T lowerLimit) where T : IComparable
		{
			if (ComparablePredicates.IsLessOrEqual(argumentFunc(), lowerLimit))
			{
				var argument = argumentFunc.GetParameter(p => p.IsLessOrEqual(lowerLimit));
				throw new ArgumentException($"The argument '{argument.Name}' must not be less than or equal to {lowerLimit}.", argument.Name);
			}
		}
	}
}