namespace MVC.Models
{
    public class ProductBL
    {
        List<Product> products;
        public ProductBL()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Tea", Price = 60, Description = "El3rosa", Image = "1.jpg" }   );
            products.Add(new Product() { Id = 2, Name = "Coffee", Price = 500, Description = "Elfaeome", Image = "2.jpg" });
            products.Add(new Product() { Id = 3, Name = "Water", Price = 5, Description = "O2", Image = "3.jpg" });

        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p=>p.Id==id);
        }
    }
}
