// Семинар 1 Задача 4 - Принимает на вход число. Выводит все четные
// от 1 до этого числа разделенные табуляцией.

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
int[]array = {1,a};
int a = array.Length;
int index = 0;
while (index<a)
{
    if(array[index]%2==0)
    {
        Console.WriteLine(array[index]);
        index++;
    }
}
