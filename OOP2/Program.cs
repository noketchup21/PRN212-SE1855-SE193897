using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barrack Obama",
    Birthday = new DateTime(1999, 10, 25)
};
Console.WriteLine("--Thong tin cua obama");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine("Name=" + obama.Name);
Console.WriteLine("IdCard=" + obama.IdCard);
Console.WriteLine("Nam sinh" + obama.Birthday.ToString("dd / MM / yyyy"));
Console.WriteLine("Muc luong obama nhan =" + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee();
trump.Id = 2;
trump.Name = "Donal Trump";
trump.IdCard= "123";
trump.Birthday = new DateTime(2025, 10, 25);
trump.WorkingHour = 5;

Console.WriteLine("--Thong tin cua obama");
Console.WriteLine($"Id={trump.Id}");
Console.WriteLine("Name=" + trump.Name);
Console.WriteLine("IdCard=" + trump.IdCard);
Console.WriteLine("Nam sinh" + trump.Birthday.ToString("dd / MM / yyyy"));
Console.WriteLine("Muc luong obama nhan =" + trump.calSalary());

Console.WriteLine("-------SU DUNG TOSTRING----------");
Console.WriteLine(obama);
Console.WriteLine(trump);