
// Задача 4. Принамает число N. Выводим сумму чисел от 1 до N.
// 9 -> 45

int Summa (int n)
{
    int summa = 0;
    for(int i = 1; i <= n; i++)
    {
    summa = summa + (i);
    }
    return summa;
}
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summa(n));


