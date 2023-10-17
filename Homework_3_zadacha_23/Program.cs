// Задача 23. Принимает число N. Выдает таблицу кубов чисел от 1 до N.

void TablCub(int n)
{
    int cur = 1;
    while (cur <= n)
    {
        System.Console.WriteLine($"{cur * cur * cur}");
        cur++;
    }
} 
System.Console.Write("Введи номер N: ");
int n = Convert.ToInt32(Console.ReadLine());
TablCub(n);


