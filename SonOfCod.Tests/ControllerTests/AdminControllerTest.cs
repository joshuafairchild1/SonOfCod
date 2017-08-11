using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class AdminControllerTest
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        [Fact]
        public void Get_ViewResult_Index()
        {
            AdminController controller = new AdminController(_userManager, _signInManager, _db);

            IActionResult result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_Register()
        {
            AdminController controller = new AdminController(_userManager, _signInManager, _db);

            IActionResult result = controller.Register();

            Assert.IsType<ViewResult>(result);
        }
    }
}
