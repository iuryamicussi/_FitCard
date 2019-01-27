using System;
using System.Web.Mvc;
using FitCard.DesafioPratico.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitCard.DesafioPratico.Tests.Controllers
{
    [TestClass]
    public class EstabelecimentosControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new EstabelecimentosController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
