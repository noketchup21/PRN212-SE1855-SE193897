/*
 * Su dung Generic List de quan ly nhan su
 * thuc hien day du tinh nang CRUD
 * C-Create --> Them moi nhan su
 * R-Read/Retrieve --> Doc: Truy van, tim kiem, sap xep...
 * U-Update --> Cap nhat thong tin nhan su
 * D-Delete --> Xoa nhan su
 */
//Cau 1 - C (Create)
//Dung List de tao 5 Employee, trong do 4 Employee la chinh thuc
//va 1 Employee la parttime
using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "John Doe",
    IdCard = "123456789",
    Birthday = new DateTime(1990, 5, 15)
};
FulltimeEmployee e2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Jane Smith",
    IdCard = "987654321",
    Birthday = new DateTime(1992, 8, 20)
};
FulltimeEmployee e3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Alice Johnson",
    IdCard = "456789123",
    Birthday = new DateTime(1988, 3, 10)
};
FulltimeEmployee e4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Bob Brown",
    IdCard = "321654987",
    Birthday = new DateTime(1995, 12, 5)
};
ParttimeEmployee e5 = new ParttimeEmployee()
{
    Id = 1,
    Name = "Charlie White",
    IdCard = "159753456",
    Birthday = new DateTime(1998, 7, 30),
    WorkingHour = 20
};
employees.Add(e1);
employees.Add(e2);
employees.Add(e3);
employees.Add(e4);
employees.Add(e5);

//Cau 2 - R -> Xuat toan bo nhan su
//Cach xuat 1:
Console.WriteLine("----Danh sach nhan su - cach 1-----");
employees.ForEach(employees => Console.WriteLine(employees));
Console.WriteLine("----Danh sach nhan su - cach 2-----");
//Cach xuat 2:
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
}

//Cau 3: R -> Loc ra nhan su chinh thuc va tinh tong luong

//Cach 1
List<FulltimeEmployee> fe_list = employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("----Danh sach nhan su chinh thuc-----");
fe_list.ForEach(fe => Console.WriteLine(fe));
//Cach 2: dung cach thong thuong
List<FulltimeEmployee> fe_list2 = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        fe_list2.Add(e as FulltimeEmployee);
    }
}
Console.WriteLine("----Danh sach nhan su chinh thuc - cach 2-----");
fe_list2.ForEach(fe => Console.WriteLine(fe));

//Tinh tong luong nhan su chinh thuc
double totalSalary = fe_list.Sum(fe => fe.calSalary());
Console.WriteLine("Tong luong nhan su chinh thuc: " + totalSalary);

//Cau 4: R --> sap xep danh sach nhan su theo ngay thang nam sinh
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            //Hoan vi
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}
Console.WriteLine("----Danh sach nhan sau sap xep-----");
employees.ForEach(e => Console.WriteLine(e));

//Sua thong tin nhan su
Console.WriteLine("----Sua thong tin nhan su-----");
Console.WriteLine("Nhap id nhan su can sua: ");
int idToUpdate = int.Parse(Console.ReadLine());
for (int i = 0; i < employees.Count; i++)
{
    if (employees[i].Id == idToUpdate)
    {
        Console.WriteLine("Nhap ten moi: ");
        employees[i].Name = Console.ReadLine();
        Console.WriteLine("Nhap so CMND moi: ");
        employees[i].IdCard = Console.ReadLine();
        Console.WriteLine("Nhap ngay thang nam sinh moi (dd/MM/yyyy): ");
        employees[i].Birthday = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        break;
    }
}
//Xuat danh sach nhan su sau khi sua
Console.WriteLine("----Danh sach nhan su sau khi sua thong tin-----");
employees.ForEach(e => Console.WriteLine(e));

//Xoa nhan su
Console.WriteLine("----Xoa nhan su-----");
Console.WriteLine("Nhap id nhan su can xoa: ");
int idToDelete = int.Parse(Console.ReadLine());
for (int i = 0; i < employees.Count; i++)
{
    if (employees[i].Id == idToDelete)
    {
        employees.RemoveAt(i);
        break;
    }
}
//Xuat danh sach nhan su sau khi xoa
Console.WriteLine("----Danh sach nhan su sau khi xoa-----");
employees.ForEach(e => Console.WriteLine(e));
