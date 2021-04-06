using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Start.Models
{
   

    public class Order
    {
        public int OrderID { get; set; }
        public int TotalAmountProductID { get; set; }
        public string ProductName { get; set; }
        public List<Product> ProductCost { get; set; }
        public List<Product> ProductID { get; set; }

    }

    public class Product
    {
        public int ProductID { get; set; }
        public string PRoductName { get; set; }
        public int ProductCost { get; set; }

        public Product PlacedProduct { get; set; }
        public Order PlacedOrder { get; set; }
    }

    public class Selection
    {
        public int SelectionID { get; set; }

        public int SelectionCost { get; set; }
        public List<Order> OrderID { get; set; }
        public List<Product> ProductID { get; set }
        
    }

    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public List<Product> ProductID { get; set; }

        public int PRoductCost { get; set; }
    }
}