using System.Text;

string ho = "Nguyen";
string tenLot = "Thi";
String ten = "Teo";
string fullname = ho+" "+tenLot+" "+ten;
Console.WriteLine( fullname );

StringBuilder sb  = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenLot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine( sb.ToString() );