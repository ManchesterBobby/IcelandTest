using Microsoft.VisualStudio.TestTools.UnitTesting;
using IcelandTest;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var inventory = new Inventory();
            var updates = inventory.UpdateInventory();

            Assert.AreEqual(updates.Count, 9);
        }
    }
}
