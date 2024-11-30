using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        //product/GetProducts
        public IActionResult GetProducts()
        {
            ProductBL productBL = new ProductBL();
            List<Product> products = productBL.GetProducts();
            return View("GetProducts", products);
        }
        public IActionResult GetProductsById(int id)
        {
            ProductBL productBL = new ProductBL();
            Product product = productBL.GetProductById(id);
            return View("GetProductsById", product);
        }
    }
}
