using Microsoft.AspNetCore.Mvc;
using btap1.Models;

namespace btap1.Controllers
{
    public class ProductController : Controller
    {
        // Danh sách sản phẩm
        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ID = 1,
                    Name = "Product 1",
                    Price = 500000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "anh1.png"
                },

                new Product
                {
                    ID = 2,
                    Name = "Product 2",
                    Price = 700000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "anh2.png"
                },

                new Product
                {
                    ID = 3,
                    Name = "Product 3",
                    Price = 550000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "anh3.png"
                },

                new Product
                {
                    ID = 4,
                    Name = "Product 4",
                    Price = 550000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "anh4.png"
                }
            };
        }


        // Hiển thị danh sách sản phẩm
        public IActionResult Index()
        {
            var products = GetProducts();

            return View(products);
        }


        // Hiển thị chi tiết 1 sản phẩm
        public IActionResult Details(int id)
        {
            var products = GetProducts();

            var product = products.FirstOrDefault(p => p.ID == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}