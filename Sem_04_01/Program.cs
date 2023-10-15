// Семинар 4. Задача 1. Принимает число. Выдает количество цифр в числе.
int Dig(int num)
{
    int count = 0;
    while (num>0)
{
    num = num/10;
    count++;
}
return count;
}
System.Console.Write("Напишите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(num + " -> " + Dig(num));



