namespace Semantity.Util.ArgumentMust
{
	using System;
	using System.Diagnostics;

	public static class ArgumentMust
	{
		[DebuggerHidden]
		public static void NotBeNull<T>(Func<T> argumentFunc) where T : class
		{
			if (argumentFunc == null)
			{
				throw new ArgumentNullException(nameof(argumentFunc));
			}

			InternalArgumentMust.NotBeNull(argumentFunc);
		}

		[DebuggerHidden]
		public static void BeGreater<T>(Func<T> argumentFunc, T lowerLimit) where T : IComparable
		{
			InternalArgumentMust.BeGreater(argumentFunc, lowerLimit);
		}
	}
}