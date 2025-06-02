using OOP5_Dictionary;

Category c1  = new Category();
c1.Id = 1;
c1.Name = "Nuoc ngot";

Product p1 = new Product();
p1.Id = 1;
p1.Name = "Coke";
p1.Quantity = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2 = new Product();
p2.Id = 2;
p2.Name = "Pepsi";
p2.Quantity = 30;
p2.Price = 15;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Quantity = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "RedBull";
p4.Quantity = 5;
p4.Price = 18;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Sprite";
p5.Quantity = 8;
p5.Price = 20;
c1.AddProduct(p5);

//Xuat toan bo san pham cua danh muc
Console.WriteLine("------Toan bo danh muc cua san pham nuoc ngot-------");
c1.PrintAllProduct();

Dictionary<int, Product> filters = c1.FilterProductByPrice(10, 15);
Console.WriteLine("----Cac san pham co gia tu 10 den 20----");
foreach(KeyValuePair<int, Product> kvp in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_result = c1.SortProductByPrice();
Console.WriteLine("------San pham sau khi sap xep-----");
foreach (KeyValuePair<int, Product> kvp in sort_result)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_result2 = c1.SortProductByPriceAndQuantity();
Console.WriteLine("------San pham sau khi sap xep theo don gia tang dan, so luong giam dan-----");
foreach (KeyValuePair<int, Product> kvp in sort_result2)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p1.Name = "Xa xi";
p1.Quantity = 30;
p1.Price = 28;
c1.UpdateProduct(p1);
Console.WriteLine("------Danh muc sau khi cap nhat san pham-----");
c1.PrintAllProduct();

int id = 3;
bool ret = c1.DeleteProduct(id);
if(ret)
{
    Console.WriteLine("Da xoa san pham co id = " + id);
} else
{
    Console.WriteLine("Khong tim thay san pham co id = " + id);
}

Category c2 = new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product { Id = 6, Name = "Sai Gon", Quantity = 20, Price = 25 });
c2.AddProduct(new Product { Id = 7, Name = "333", Quantity = 10, Price = 250 });
c2.AddProduct(new Product { Id = 8, Name = "Ken", Quantity = 7, Price = 215 });

LinkedList<Category> ss = new LinkedList<Category>();
ss.AddLast(c1);
ss.AddLast(c2);
Console.WriteLine("------Danh sach danh muc san pham-----");
foreach (Category c in ss)
{
    Console.WriteLine($"Danh muc: {c.Name}");
    Console.WriteLine("***********");
    c.PrintAllProduct();
    Console.WriteLine("***********");
}