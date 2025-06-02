using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        //Moi du lieu can lam du CRUD
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                return; //vi ma ton tai
            }
            else
            {
                Products.Add(p.Id, p);
                Console.WriteLine($"Product {p.Name} added successfully.");
            }
        }
        //Xem toan bo Product cua danh muc
        public void PrintAllProduct()
        {
            foreach(KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }
        //Loc ra cac san pham co gia tu x toi y
        public Dictionary<int, Product> FilterProductByPrice(double min, double max)
        {
            Dictionary<int, Product> results = new Dictionary<int, Product>();
            results = (Dictionary<int, Product>)Products.Where(item => item.Value.Price >= min && item.Value.Price <= max).ToDictionary<int, Product>();
            return results;
        }
        //Sap xep san pham theo don gia tang dan
        public Dictionary<int, Product> SortProductByPrice()
        {
            return Products.OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }
        //Sap xep san pham theo don gia tang dan, neu don gia trung nhau thi sap xep theo so luong giam dan
        public Dictionary<int, Product> SortProductByPriceAndQuantity()
        {
            return Products.OrderBy(item => item.Value.Price)
                           .ThenByDescending(item => item.Value.Quantity)
                           .ToDictionary<int, Product>();
        }
        public bool UpdateProduct(Product p)
        {
            if(p is null)
            {
                return false;
            }
            if (Products.ContainsKey(p.Id) == false) return false;
            Products[p.Id] = p; //tham chieu o nho
            return true;
        }
        public bool DeleteProduct(int id)
        {
            if (Products.ContainsKey(id) == false) return false;
            Products.Remove(id);
            return true;
        }
    }
}
