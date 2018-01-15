using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Abstract;

namespace SportsStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //public ActionResult List()
        //{
        //    var db = new EFDbContext();
        //    var query = from b in db.products
        //                orderby b.Name
        //                select b;
        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.Name);
        //    }
        //    return View();
        //}


        private IProductsRepository repository;

        public ProductController(IProductsRepository productRepository)
        {
            this.repository = productRepository;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}