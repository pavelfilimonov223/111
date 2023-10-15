// Задача 4. Принимает число N. Выдает таблицу квадратов чисел от 1 до N.

void TablSc(int n)
{
    int cur = 1;
    while (cur <= n)
    {
        System.Console.WriteLine($"{cur * cur}");
        cur++;
    }
} 
System.Console.Write("Введи номер N: ");
int n = Convert.ToInt32(Console.ReadLine());
TablSc(n);

