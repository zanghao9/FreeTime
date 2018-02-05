using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Controllers;
namespace SportsStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            //Mock<IProductsRepository> mock = new Mock<IProductsRepository>();
            //mock.Setup(m => m.Products).Returns(new product[] {
            //    new product{ProductID=1,Name="p1"},
            //    new product{ProductID=2,Name="p2"},
            //    new product{ProductID=3,Name="p3"},
            //    new product{ProductID=4,Name="p4"},
            //    new product{ProductID=5,Name="p5"}
            //});
            //ProductController controller = new ProductController(mock.Object);
            //controller.PageSize = 3;

            //IEnumerable<product> result = (IEnumerable<product>)controller.List(2).Model;
        }
    }
}
