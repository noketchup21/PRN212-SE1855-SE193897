int n = -1;
while (n < 0)
{
    Console.WriteLine("Nhap n>=0: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out n) == true)
    {
        if (n >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Nhap n>=0");
        }

    }
    else
    {
        Console.WriteLine("Nhap so brr brr patapim");
    }
}

int gt = 1;
for (int i = 1; i <= n; i++)
{
    gt *= i;
}
Console.WriteLine("Giai thua cua {0} la {1}", n, gt);
