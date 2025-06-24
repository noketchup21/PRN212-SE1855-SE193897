using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
namespace DataAccessLayer
{
    public class ProductDAO
    {
        List<Product> products = new List<Product>();
        public void GenerateSampleDataset()
        {
            products.Add(new Product() { Id = 1, Name = "Coca", Quantity = 10, Price = 100});
            products.Add(new Product() { Id = 2, Name = "Pepsi", Quantity = 20, Price = 200 });
            products.Add(new Product() { Id = 3, Name = "Sprite", Quantity = 30, Price = 300 });
            products.Add(new Product() { Id = 4, Name = "Fanta", Quantity = 40, Price = 400 });
            products.Add(new Product() { Id = 5, Name = "7Up", Quantity = 50, Price = 500 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool SaveProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old != null)
            {
                return false;
            }
            products.Add(product);
            return true;
        }
        public bool UpdateProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old == null)
            {
                return false; //ko tim thay ko sua
            }
            old.Name = product.Name;
            old.Quantity = product.Quantity;
            old.Price = product.Price;
            return true;
        }
        public bool DeleteProduct(Product product)
        {
            Product old = products.FirstOrDefault(p => p.Id == product.Id);
            if (old == null)
            {
                return false; //ko tim thay ko xoa
            }
            products.Remove(old);
            return true;
        }
    }
}
