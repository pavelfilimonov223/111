// Задача 3. Принимает число N. Выводим произведение чисел от 1 до N.
// 4 -> 1*2*3*4 = 24

int Factorial(int n)
{
    int fact = 1;
    for (int i=1; i <= n; i++)
    {
        fact = fact * (i);
    }
    return fact;
}
System.Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Factorial(n));

