using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroletra.Controllers;

namespace UnitTestConversor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteral()
        {
            //arrange
            LiteralController literalController = new LiteralController();
            int val = 5;
            string esperado = "cinco";

            //act
            string resultado = literalController.Literalget(val);
            //assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
