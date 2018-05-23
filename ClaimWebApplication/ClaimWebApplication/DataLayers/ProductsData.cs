using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClaimWebApplication.Models;
namespace ClaimWebApplication.DataLayers
{
    public class ProductsData
    {
        NorthwindEntities db = new NorthwindEntities();
        public List<Category> GetAllCategories()
        {
            try
            {
                return db.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                return db.Products.Where(x => x.Discontinued == true).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}