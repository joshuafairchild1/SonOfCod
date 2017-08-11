using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        private readonly AppDbContext _db;

        [Fact]
        public void Get_ViewResult_Index()
        {
            HomeController controller = new HomeController(_db);

            IActionResult result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
