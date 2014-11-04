using System;
using Framework.Interfaces.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework.Repositories;

namespace Demo.Test.Business
{
	[TestClass]
	public abstract class BusinessTest<TEntity, TBusiness>
		where TEntity : class, new()
		where TBusiness : IBusiness<TEntity>, new()
	{
		public static Lazy<TBusiness> bizEntity { get; set; }

		public static void Startup()
		{
			bizEntity = new Lazy<TBusiness>();
		}

		public static void TearDown() { }
	}
}
