using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.Controllers
{
  public class DatabaseExampleController : Controller
  {
    public ApplicationDbContext dbContext;

    public DatabaseExampleController(ApplicationDbContext context)
    {
      dbContext = context;
    }

    public IActionResult Index()
    {
      return View();
    }

    public async Task<ViewResult> DatabaseOperations()
    {
      // MY best attempt in populating tables, Home Controller has another attempt as well

      Store MyCompany = new Store();
      MyCompany.StoreID = 1;
      MyCompany.StoreName = "Blue";
      MyCompany.ProductID = 2;
      MyCompany.PRoductCost = 5;

      Product MyCompanyQuote1 = new Product();
     
      MyCompanyQuote1.ProductID = 111;
            MyCompanyQuote1.PRoductName = "Blue  Berries" ;
      MyCompanyQuote1.ProductCost = 77;
     

      Order MyCompanyQuote2 = new Order();
      MyCompanyQuote2.OrderID = 112;
      MyCompanyQuote2.ProductID = 4;
      MyCompanyQuote2.ProductName = "Apples";
      MyCompanyQuote2.TotalAmountProductID = 33;


            Selection myCompanyQoute3 = new Selection();
            myCompanyQoute3.SelectionID = 55;
            myCompanyQoute3.ProductID = 88;
            myCompanyQoute3.ProductName = "Grapes";
            myCompanyQoute3.OrderID = 77;
            myCompanyQoute3.SelectionCost = 999;

      dbContext.stores.Add(MyCompany);
      dbContext.Orders.Add(MyCompanyQuote1);
      dbContext.Selections.Add(MyCompanyQuote2);
            dbContext.Products.Add(MyCompanyQuote2);

            dbContext.SaveChanges();
      
      

     

    public ViewResult LINQOperations()
    {
      
                // Attempt with psuedo code for first query

                // You would use Stores Stores Read1=db.stores
                // where (c = .ProductName== "Apples")


                // My attempt at the second Query 

                //You would use orders 
                //You would query products table and send a query to return product with biggest amount
                
               

     

      return View();
    }

  }
}