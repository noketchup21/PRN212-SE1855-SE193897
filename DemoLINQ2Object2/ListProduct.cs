using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLINQ2Object2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_products()
        {
            Product p1 = new Product() { Id = 1, Name = "P1", Quantity = 30, Price = 50 };
            Product p2 = new Product() { Id = 2, Name = "P2", Quantity = 310, Price = 590 };
            Product p3 = new Product() { Id = 3, Name = "P3", Quantity = 320, Price = 580 };
            Product p4 = new Product() { Id = 4, Name = "P4", Quantity = 330, Price = 570 };
            Product p5 = new Product() { Id = 5, Name = "P5", Quantity = 330, Price = 560 };
            Product p6 = new Product() { Id = 6, Name = "P6", Quantity = 340, Price = 550 };
            Product p7 = new Product() { Id = 7, Name = "P7", Quantity = 350, Price = 540 };
            Product p8 = new Product() { Id = 8, Name = "P8", Quantity = 360, Price = 530 };
            Product p9 = new Product() { Id = 9, Name = "P9", Quantity = 370, Price = 520 };
            Product p10 = new Product() { Id = 10, Name = "P10", Quantity = 380, Price = 510 };
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);
            products.Add(p6);
            products.Add(p7);
            products.Add(p8);
            products.Add(p9);
            products.Add(p10);

        }
        public List<Product>FilterProductsByPrice(double price1, double price2)
        {
            return products.Where(p => p.Price >= price1 && p.Price  <= price2).ToList();
        }
        public List<Product> FilterProductsByPrice2(double price1, double price2)
        {
            var results = from p in products where p.Price >= price1 && p.Price <= price2 select p;
            return results.ToList();
        }
        public List<Product> SortProductByPriceDescending()
        {
            return products.OrderByDescending(p => p.Price).ToList();
        }
        public List<Product> SortProductByPriceDescending2()
        {
            var results = from p in products orderby p.Price descending select p;
            return results.ToList();
        }
        public double SumOfValue()
        {
            return products.Sum(p => p.Price* p.Price);
        }
    }
}
