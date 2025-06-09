using DemoLINQ2Object2;

ListProduct lp = new ListProduct();
lp.gen_products();
//Cau 1: loc ra cac san pham co gia tu a toi b
//su dung method syntax va query syntax
var result1 = lp.FilterProductsByPrice(200, 300);
Console.WriteLine("Danh sach san pham co gia tu 200 - 300:");
result1.ForEach(x => Console.WriteLine(x));

//Cau 2: sap xep cac san pham theo don gia giam dan
var result2 = lp.SortProductByPriceDescending2();
Console.WriteLine("Danh sach san pham co gia giam dan:");
result2.ForEach(x => Console.WriteLine(x));

//Cau 3: Tinh tong gia tri san pham trong kho hang
Console.WriteLine("Tong gia tri: " + lp.SumOfValue());