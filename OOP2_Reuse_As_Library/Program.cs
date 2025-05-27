using OOP2;
using OOP2_Reuse_As_Library;

FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "John Doe";
e1.IdCard = "123456789";
e1.Birthday = new DateTime(1990, 5, 15);
Console.WriteLine("---Thông tin nhân viên toàn thời gian---");
Console.WriteLine(e1);
Console.WriteLine("AGE = " + e1.TinhTuoi());