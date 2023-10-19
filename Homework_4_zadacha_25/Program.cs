// ДЗ семинар 4. Задача 25
// Написать цикл, на вход два числа a и b. На выходе a в степени b. 
double FindS(double a, double b)
{
    return Math.Pow(a,b);
}
System.Console.Write("Введите A: ");
double a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите B: ");
double b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{a}, {b} -> {FindS(a, b)}");
