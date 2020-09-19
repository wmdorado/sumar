using Microsoft.VisualStudio.TestTools.UnitTesting;
using sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            sumaController SumaController = new sumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;


            //Act
            int resultado = SumaController.Add(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
