namespace Semantity
{
	public static class ForceDoubleExtensions
	{
		public static Force Newton(this double value)
		{
			return new Force(value, Semantity.Newton.Instance);
		}
	}
}