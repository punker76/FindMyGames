using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameMetadata.Net.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            SearchedGame result = new MetadataClient().GetGameMetadata("Battlefield 1")
               .Result;
            Assert.IsTrue(true);
        }
    }
}
