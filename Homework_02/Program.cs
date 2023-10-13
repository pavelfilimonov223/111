// Семинар 1 Задача 2 - Принимает на вход 3 числа. Выводит максимальное.
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число d: ");
int d = Convert.ToInt32(Console.ReadLine());
int max = a;
if(a>max) max=a;
if(b>max) max=b;
if(d>max) max=d;
Console.Write("max=");
Console.WriteLine(max);


