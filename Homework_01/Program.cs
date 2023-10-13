// Семинар 1 Задача 1
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a<b)
{
    System.Console.Write($"Первое число {a} меньше чем второе число {b}");
}
else if(a>b)
{
   System.Console.Write($"Это не верно. Первое число {a} больше, чем второе число {b} ");
}
else if(a==b)
{
    System.Console.Write($"Введенные числа равны {a}");
}

