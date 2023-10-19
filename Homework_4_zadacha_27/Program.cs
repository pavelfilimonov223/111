// ДЗ семинар 4. Задача 27
// Принимает число. Выдает сумму цифр в числе.

int Summa (int n)
{
    int summa = n%10;
    for(int i = n; i <= n; i++)
    {
    summa = summa + i;
    }
    return summa;
}
System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Summa(n));




