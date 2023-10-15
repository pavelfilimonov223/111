// По координатам двух точек найти расстояние между ними (по теореме Пифагора).

double FindDist(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya,2)), 2);
}
System.Console.Write("Введите XA: ");
double xa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите YA: ");
double ya = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите XB: ");
double xb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите YB: ");
double yb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"A({xa},{ya}), B({xb},{yb}) -> {FindDist(xa, ya, xb, yb)}");


