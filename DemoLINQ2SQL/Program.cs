using System.ComponentModel;
using DemoLINQ2SQL;

string connectionString = "server=LAPTOP-JUBLI2B6\\SQLEXPRESS;database=MyStore;uid=SA;pwd=12345;TrustServerCertificate=True";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau 1: Truy van toan bo danh muc
var dsdm = context.Categories.ToList();
Console.WriteLine("Cac danh muc trong CSDL:");
dsdm.ForEach(x => Console.WriteLine(x.CategoryID+"\t"+ x.CategoryName));
//Cau 2: Dung query syntax de loc ra toan bo san pham
var dsp = from p in context.Products select p;
Console.WriteLine("Cac san pham trong CSDL:");
foreach (var p in dsp)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}
//Cau 3: Tim danh muc khi biet ma danh muc
int dmd = 3;
Category cate = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if (cate == null)
{
    Console.WriteLine("Khong tim thay danh muc co ma: " + dmd);
}
else
{
    Console.WriteLine("Danh muc co ma " + dmd);
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}
//Cau 4: Loc ra top 3 san pham co gia lon nhat
var dssptop3 = context.Products
    .OrderByDescending(x => x.UnitPrice)
    .Take(3)
    .ToList();
Console.WriteLine("Top 3 san pham co gia lon nhat:");
foreach (var p in dssptop3)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}
//Cau 5: Them moi 1 danh muc
/*Category c1 = new Category();
c1.CategoryName = "Hang dien tu";
context.Categories.InsertOnSubmit(c1);
context.SubmitChanges();*/

//Cau 6: Sua ten danh muc
//Buoc 1 tim danh muc
//Buoc 2 tim thay thi sua

Category c10 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if (c10 != null)
{
    c10.CategoryName = "Hang dien lanh";
    context.SubmitChanges();
}
//Cau 7 : Xoa danh muc khi biet ma danh muc
Category c9 = context.Categories.FirstOrDefault(x => x.CategoryID == 9);
if (c9 != null)
{
    context.Categories.DeleteOnSubmit(c9);
    context.SubmitChanges();
}
//Cau 8: Xoa tat ca danh muc chua co bat ky san pham nao
var dssp_empty_product = context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dssp_empty_product);
context.SubmitChanges();
//Cau 9: Them nhieu danh muc cung 1 luc
List<Category> newCategories = new List<Category>();
newCategories.Add(new Category() { CategoryName = "Hang thoi trang" });
newCategories.Add(new Category() { CategoryName = "Hang gia dung" });
newCategories.Add(new Category() { CategoryName = "Hang the thao" });
context.Categories.InsertAllOnSubmit(newCategories);
context.SubmitChanges();