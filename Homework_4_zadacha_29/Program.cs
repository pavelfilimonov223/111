// Задача 2. Заполнить массив из 8 элементов и вывести на экран.

int[]CRarray(int minV, int maxV)
{
    int[]array = new int[8];
    for(int i = 0; i<8; i++)
    {
        array[i]= new Random().Next(minV, maxV+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}
System.Console.Write("Введите минимальное значение: ");
int minV = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное значение: ");
int maxV = Convert.ToInt32(Console.ReadLine());
PrintArray(CRarray(minV, maxV));
