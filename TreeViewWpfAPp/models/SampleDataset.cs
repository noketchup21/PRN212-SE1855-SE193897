using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWpfAPp.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category() { Id = 1, Name = "Nuoc ngot" };
            Category c2 = new Category() { Id = 2, Name = "Do an nhanh" };
            Category c3 = new Category() { Id = 3, Name = "Do uong" };

            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            Product p1 = new Product() { Id =1, Name = "Coca", Quantity= 1, Price= 20 };
            Product p2 = new Product() { Id = 2, Name = "Pepsi", Quantity = 1, Price = 20 };
            Product p3 = new Product() { Id = 3, Name = "Sprite", Quantity = 1, Price = 20 };
            Product p4 = new Product() { Id = 4, Name = "Fanta", Quantity = 1, Price = 20 };
            Product p5 = new Product() { Id = 5, Name = "7Up", Quantity = 1, Price = 20 };
            Product p6 = new Product() { Id = 6, Name = "Hamburger", Quantity = 1, Price = 50 };
            Product p7 = new Product() { Id = 7, Name = "Pizza", Quantity = 1, Price = 100 };
            Product p8 = new Product() { Id = 8, Name = "Hotdog", Quantity = 1, Price = 30 };
            Product p9 = new Product() { Id = 9, Name = "Tra sua", Quantity = 1, Price = 25 };
            Product p10 = new Product() { Id = 10, Name = "Sinh to", Quantity = 1, Price = 30 };
            Product p11 = new Product() { Id = 11, Price = 15, Name = "Nuoc ep", Quantity = 1 };
            Product p12 = new Product() { Id = 12, Price = 10,Name = "Nuoc dua", Quantity = 1 };
            Product p13 = new Product() { Id = 13, Price = 12,Name = "Nuoc loc", Quantity = 1 };
            Product p14 = new Product() { Id = 14, Price = 18, Name = "Nuoc yen", Quantity = 1 };
            Product p15 = new Product() { Id = 15, Price = 22, Name = "Nuoc cam", Quantity = 1 };

            c1.Products.Add(p1.Id, p1);
            c1.Products.Add(p2.Id, p2);
            c1.Products.Add(p3.Id, p3);
            c1.Products.Add(p4.Id, p4);
            c1.Products.Add(p5.Id, p5);

            c2.Products.Add(p6.Id, p6);
            c2.Products.Add(p7.Id, p7);
            c2.Products.Add(p8.Id, p8);
            c2.Products.Add(p9.Id, p9);
            c2.Products.Add(p10.Id, p10);

            c3.Products.Add(p11.Id, p11);
            c3.Products.Add(p12.Id, p12);
            c3.Products.Add(p13.Id, p13);
            c3.Products.Add(p14.Id, p14);
            c3.Products.Add(p15.Id, p15);

            return categories;
        }
    }
}
