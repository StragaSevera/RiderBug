using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Controllers;
using WebApplication.Models;
using Xunit;

namespace WebApplication.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Can_Get_Valid_Content()
        {
            var controller = new HomeController();

            var result = (ViewResult) controller.Index();
            var model = (Home) result.ViewData.Model;

            Assert.Equal("Valid content", model.Content);
        }
    }
}