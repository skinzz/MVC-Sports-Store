using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.WebUI.Infrastructure.Logging;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
       
        public int PageSize = 4; 
        private IProductRepository repository;
        //private ILogger _logger;

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
            //_logger = logger;
        }

        public ViewResult List(string category, int page = 1)
        {
            //_logger.LogInfo("Logging from the List Controller!!");

            var viewModel = new ProductsListViewModel
                            {
                                Products = repository.Products
                                    .Where(p => category == null || p.Category == category)
                                    .OrderBy(p => p.ProductID)
                                    .Skip((page - 1) * PageSize)
                                    .Take(PageSize),
                                PagingInfo = new PagingInfo
                                                {
                                                    CurrentPage =  page,
                                                    ItemsPerPage = PageSize,
                                                    TotalItems = repository.Products.Count()
                                                },
                                CurrentCategory = category
                            };
            return View(viewModel);

            //return View(repository.Products
            //    .OrderBy(p => p.ProductID)
            //    .Skip((page - 1) * PageSize)
            //    .Take(PageSize));
        }
    }
}
