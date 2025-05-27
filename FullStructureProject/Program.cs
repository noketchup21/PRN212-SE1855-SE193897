namespace FullStructureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //           Console.WriteLine("Cha me \"thoi\" doi an o bac");
            //           Console.WriteLine("Co chong ca chon cung nhu khong");
            //           Console.WriteLine("Cac doi so dau vao cua ban: ");
            Console.WriteLine("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int tong = 0;
            for (int i = 0; i <= n; i++)
            {
                tong += i;
            }
            Console.WriteLine(tong);

        }
    }
}