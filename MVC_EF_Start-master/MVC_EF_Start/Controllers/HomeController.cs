using Microsoft.AspNetCore.Mvc;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;
using System;

namespace MVC_EF_Start.Controllers
{
    public class HomeController : Controller
    {

        public ApplicationDbContext dbContext;
        public HomeController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {

            // As mentioned in notes DatabaseExampleController I wasn't certain where to try to populte the tables so I attempted them here
            Order Myorder = new Order { ProductCost = 100 };
            Product Myproduct = new Product { ProductName = "Soda" };
            Store Store = new Store
            {
                PlacedOrder = Myorder,
                PlacedProduct = Myproduct,
              
            };

            Order Myorder1 = new Order { TotalAmount = 30 };
            Product Myproduct1 = new Product { ProductName = "Soap" };
             store store2 = new store
            
             {
                PlacedOrder = Myorder1,
                PlacedProduct = Myproduct1,
               
            };

            Order Myorder2 = new Order { ProductCost = 10 };
            Product Myproduct2 = new Product { ProductName = "bar soap" };
            Order Myorder3 = new Order { TotalAmount = 0 };
            Product Myproduct3 = new Product { ProductName = "razors" };
            
            store placed3 = new store
            {
                PlacedOrder = Myorder2,
                PlacedProduct = Myproduct2,
               
            };


            Store store3 = new Store
            {
                PlacedOrder = Myorder3,
                PlacedProduct = Myproduct2,
                
            };

           


            
            return View();
        }
    }
}