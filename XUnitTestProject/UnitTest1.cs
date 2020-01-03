using Microsoft.AspNetCore.Mvc;
using MySqlDotnetCore.Controllers;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1 
    {
        [Fact]
        public void Test1()
        {
            HomeController hc = new HomeController();
            IActionResult view = hc.About();
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            ManageController mc = new ManageController();
            IActionResult view = mc.ResetAuthenticatorWarning();
            Assert.True(true);
        }

        // test
        [Fact]
        public void Test3() 
        {
            AccountController ac = new AccountController();
            IActionResult view = ac.ResetPasswordConfirmation();
            Assert.True(true);
        }
    }
}