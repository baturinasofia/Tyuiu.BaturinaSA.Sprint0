using Tyuiu.BaturinaSA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BaturinaSA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Софья";
            var res = DataServise.GetMessage(name);

            Assert.AreEqual("Привет, Софья", res);
        }
    }
}
