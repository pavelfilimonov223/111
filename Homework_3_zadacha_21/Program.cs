// По координатам двух точек в 3D пространстве найти расстояние между ними 
// (по теореме Пифагора).
double FindDist(double xa, double ya, double xb, double yb, double za, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya,2) + Math.Pow(zb-za,2)), 2);
}
System.Console.Write("Введите XA: ");
double xa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите YA: ");
double ya = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ZA: ");
double za = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите XB: ");
double xb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите YB: ");
double yb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите ZB: ");
double zb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"A({xa},{ya},{za}), B({xb},{yb},{zb}) -> {FindDist(xa, ya, xb, yb, za, zb)}");


