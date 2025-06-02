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