using System.Net.WebSockets;

int[] arr = { 20, 12, 43, 65, 234, 76, 12, 543, 31 };
//Cau 1: Loc ra cac so chan
//Cach 1: Dung Extension Method - Method Syntax
var ar_chan = arr.Where(x => x % 2 == 0);
Console.WriteLine("Cac so chan - Method Syntax:");
ar_chan.ToList().ForEach(x => Console.WriteLine(x));

//Cach 2: Dung Query Syntax
var ar_chan2 = from x in arr where x % 2 == 0 select x;
Console.WriteLine("Cac so chan - Query Syntax");
ar_chan2.ToList().ForEach(x => Console.WriteLine(x));

//Cau 2: Tang cac phan tu len 2 don vi
var arr2 = arr.Where(x => x % 2 != 0).Select(x => x + 2);
Console.WriteLine("\nDu lieu goc:");
foreach(var x in arr)
{
    Console.WriteLine(x + "\t");
}
Console.WriteLine("\nDu lieu sau khi tang so le:");
foreach (var x in arr2)
{
    Console.WriteLine(x + "\t");
}

//Cau 3: Sap xep cac phan tu tang dan
var arr4 = arr.OrderBy(x => x);
var arr5 = from x in arr orderby x select x;
Console.WriteLine("\nSau khi xep tang dan");
foreach(var x in arr4)
{
    Console.WriteLine(x);
}

//Cau 4: Sap xep giam dan
var arr6 = arr.OrderByDescending(x => x);
var arr7 = from x in arr orderby x descending select x;

//Cau 5: Dem cac phan tu le
Console.WriteLine("So le la = " + arr.Where(x => x % 2 != 0).Count());
int sole = (from x in arr where x % 2 != 0 select x + 2).Count();
Console.WriteLine("So le = "+sole);