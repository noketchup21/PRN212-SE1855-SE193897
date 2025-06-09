using DemoAliasAndClone;

Student s1 = new Student();
s1.Id = 1;
s1.Name = "Alice";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Bob";

//Luc nay tren thanh RAM cap phat 2 o nho cho s1 va s2 quan ly
//=> s1 doi gia tri ko lien quan den s2 vi s1 va s2 dang quan ly 2 o nho khac nhau
s1 = s2;
// ta viet lenh s1 = s2
//Tuy nhien ve ban chat no hoat dong nhu sau
// s1 tro toi vung nho ma s2 dang quan ly chu ko phai s1 bang s2
//co 2 tinh huong xay ra
//1. o nho ben s2 gio co them s1 quan ly ==> alias (>=2 doi tuong quan ly)
// chi can 1 doi tuong doi thi doi tuong khac deu bi doi
s2.Name = "Charlie";
Console.WriteLine("s2 doi ten s1 co ten gi?");
Console.WriteLine(s1.Name);
//2. o nho ben s1 gio khong con quan ly s1 nua thi HDH tu dong tu hoi o nho: Automatic Garbage Collection
//tuc la ta ko the truy suat de lay lai gia tri s1 co id =1, name = alice

Product p1 = new Product() { Id = 1, Name = "P1", Quantity = 10, Price = 20 };
Product p2 = new Product() { Id = 2, Name = "P2", Quantity = 20, Price = 15 };

p1 = p2;

p2.Name = "P2 name";
p2.Price = 80;

Console.WriteLine("Thong tin cua p1:");
Console.WriteLine(p1);

Product p3 = new Product() { Id = 3, Name = "P3", Quantity = 30, Price = 50 };
Product p4 = new Product() { Id = 4, Name = "P4", Quantity = 40, Price = 90 };
Product p5 = p3;
p3 = p4;
//Hoi o nho cap phat cho p3 co bi thu hoi khong? Vi sao?

Product p6 = p4.clone();
//sao chep toan bo du lieu  trong o nho ma p4 dang quan ly sang o nho moi  va giao cho p6 quan ly
//luc nay khong phai  la ALIAS vi p4 va p6 quan ly 2 o nho khac nhau
Console.WriteLine("Du lieu product 6:");
Console.WriteLine(p6);
Console.WriteLine("Du lieu product 4:");
Console.WriteLine(p4);
p4.Name = "Thuoc LMAO";
Console.WriteLine("Du lieu product 6:");
Console.WriteLine(p6);
Console.WriteLine("Du lieu product 4:");
Console.WriteLine(p4);