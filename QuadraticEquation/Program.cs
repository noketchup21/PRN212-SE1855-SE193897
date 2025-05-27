void first_degree_solution(double a, double b)
{
    if (a == 0 && b == 0)
    {
        Console.WriteLine("Vo so nghiem");
    }
    else if (a == 0 && b != 0)
    {
        Console.WriteLine("Vo nghiem");
    }
    else
    {
        Console.WriteLine("X = {0}", -b / a);
    }
}
void quadratic_equaton_solution (double a, double b, double c)
{
    if(a == 0)
    {
        first_degree_solution(b, c);
    }
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if(delta < 0)
        {
            Console.WriteLine("Vo nghiem");
        }
        else if(delta == 0)
        {
            Console.WriteLine("X1 = X2 = {0}", -b/(2*a));
        }
        else
        {
            var x1 = (-b - Math.Sqrt(delta))/(2*a);
            var x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("X1 = {0}\nX2 = {1}", x1, x2);
        }
    }
}

Console.WriteLine("Nhap a: ");
var a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
var b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap c: ");
var c = Double.Parse(Console.ReadLine());
quadratic_equaton_solution(a, b, c);