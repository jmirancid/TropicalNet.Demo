using Demo.Business.Definitions;
using Demo.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Test.Business
{
	[TestClass]
	public class AlbumRepositoryTest : BusinessTest<Album, AlbumBusiness>
	{
		[ClassInitialize()]
		public static void Initialize(TestContext testContext)
		{
			Startup();
		}

		[ClassCleanup()]
		public static void Cleanup()
		{
			TearDown();
		}

		[TestMethod]
		public void Can_GetAll_Albums()
		{
			var list = bizEntity.Value.All();

			Assert.IsNotNull(list);
		}

		[TestMethod]
		public void Can_GetAllByText_Albums()
		{
			var list = bizEntity.Value.AllBy(e => e.Title.Contains("world"));

			Assert.IsNotNull(list);
		}
	}
}
