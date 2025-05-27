using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;
//Tao 1 doi tuong danh muc
Category c1 = new Category();
//Gan gia tri cho cac thuoc tinh
c1.Id = 1;
c1.Name = "Nuoc mam";
//goi ham xuat du lieu
c1.PrintInfo();

//Khoi tao 1 nhan vien
Employee e1 = new Employee();
e1.Id = 1; //goi setter property Id
e1.Id_card = "123456789"; //goi setter property Id_card
e1.Name = "Nguyen Van A"; //goi setter property Name
e1.Email = "teo@gmail.com"; //goi setter property Email
e1.Phone = "0123456789"; //goi setter property Phone
//goi ham xuat thong tin
e1.PrintInfo();
//Ta co the truy suat theo tung property de lay gia tri cua thuoc tinh
Console.WriteLine("------------");
Console.WriteLine($"Id: {e1.Id}");
Console.WriteLine($"Name cua e1 = {e1.Name}");

//Ta cung co the khoi tao doi tuong va cac gia tri cua thuoc tinh nhu sau
Employee e2 = new Employee()
{
    Id = 2,
    Id_card = "0055",
    Name = "Ty",
    Email = "ty@gmail.com",
    Phone = "0123456789"
};
Console.WriteLine("------------");
e2.PrintInfo();

Console.WriteLine("------------");
Employee e3 = new Employee(3,"0088","Tam","Tam@gmail.com","0933234243");
e3.PrintInfo();
Console.WriteLine(e3);

Employee e4 = new();
Console.WriteLine(e4);

//Tao doi tuong customer
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyen Van A",
    Email = "fdfd@gmail.com",
    Phone = "0123456789",
    Address = "Ha Noi"
};
cus1.PrintInfo();
cus1.Address = "TP HCM";
cus1.Phone = "0987654321";
Console.WriteLine("Thong tin khach hang sau khi cap nhat");
cus1.PrintInfo();