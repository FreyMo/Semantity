using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Semantity.Test
{
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;
	using AreaQuantity;
	using Definitions;
	using LengthQuantity.Extensions;

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var res = Assembly.Load("Semantity");
		}

		void Get()
		{
			var res = Assembly.Load("Semantity");
			var types = res.GetTypes().Where(x => x.ContainsGenericParameters).Where(x => x.FullName.StartsWith("Semantity"));
		}
	}

}
