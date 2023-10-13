// Семинар 1 Задача 3 - Принимает на вход число. Выводит четное оно или нет.

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a%2==0)
{
    Console.WriteLine($"{a} -> Число {a} четное");
}
else
{
  Console.WriteLine($"{a} -> Число {a} нечетное");  
}
