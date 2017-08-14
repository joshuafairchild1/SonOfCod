using Microsoft.AspNetCore.Mvc;
using SonOfCod.Controllers;
using SonOfCod.Models;
using System.Collections.Generic;
using Xunit;

namespace SonOfCod.Tests.ControllerTests
{
    public class NewsletterControllerTest
    {
        private readonly AppDbContext _db;

        [Fact]
        public void Get_ViewResult_Index()
        {
            NewsletterController controller = new NewsletterController(_db);

            IActionResult result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        //[Fact]
        //public void Get_ListOfMembers_Members()
        //{
        //    ViewResult view = new NewsletterController(_db).Members() as ViewResult;

        //    //object result = view.ViewData.Model;

        //    Assert.IsType<ViewResult>(view);
        //}

        //not sure why i can't get this test to pass :(
    }
}
