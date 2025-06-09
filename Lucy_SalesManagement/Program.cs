using Lucy_SalesManagement;

string connectionString = "server=LAPTOP-JUBLI2B6\\SQLEXPRESS;database=Lucy_SalesData;uid=SA;pwd=12345;TrustServerCertificate=True";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//Cau 1: lay chi tiet thong tin khach hang khi biet ma
int mkh = 1;
Customer cust = context.Customers.FirstOrDefault(x => x.CustomerID == mkh);
if(cust != null)
{
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}
//Cau 2: lap ra danh sach cac hoa don cua khach hang tim thay
if (cust != null)
{
    Console.WriteLine("Danh sach hoa don cua khach hang");
    foreach (Order od in cust.Orders)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}
//Cau 3: Nang cap cau 2 bo sung them 1 cot hien thi tri gia cua hoa don
Console.WriteLine("Danh sach hoa don cua khach hang");
Order oder = new Order();
Order_Detail odetail = new Order_Detail();
foreach (Order o in cust.Orders)
{
    oder = context.Orders.FirstOrDefault(x => x.OrderID == o.OrderID);
    if (oder != null)
    {
        decimal totalPrice = 0;
        foreach (Order_Detail detail in oder.Order_Details)
        {
            totalPrice = detail.UnitPrice * detail.Quantity;
            Console.WriteLine(oder.OrderID + "\t" + oder.OrderDate.ToString("dd/MM/yyyy") + "\t" + totalPrice);
        }

    }
}
