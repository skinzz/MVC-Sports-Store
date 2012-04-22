using System;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Controllers;
using System.Web.Mvc;
using SportsStore.WebUI.HtmlHelpers;
using SportsStore.WebUI.Models;
using NUnit.Framework;

namespace SportsStore.UnitTests
{
    [TestFixture]
    public class ProdRepo : TestBase
    {
        //[Test]
        //public void valid_something()
        //{
        //   this.IsPending();
        //}
 
        [Test]
        public void Can_Generate_Page_Links()
        {
            HtmlHelper myHelper = null;

            PagingInfo pagingInfo = new PagingInfo
            {
                CurrentPage = 2,
                TotalItems = 28,
                ItemsPerPage = 10
            };
            Func<int, string> pageUrlDelegate = i => "Page" + i;

            MvcHtmlString result = myHelper.PageLinks(pagingInfo, pageUrlDelegate);

            Assert.AreEqual(result.ToString(), @"<a href=""Page1"">1</a><a class=""selected"" href=""Page2"">2</a><a href=""Page3"">3</a>");
        }
    }
}
