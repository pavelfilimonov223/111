// Задача 2. Заполнить массив из 8 элементов из случайных 1 и 0.
// [0,1,0,0,1,1,0,1]

int[]CRarray(int size, int minV, int maxV)
{
    int[]array = new int[size];
    for(int i = 0; i<array.Length; i++)
    {
        array[i]= new Random().Next(minV, maxV+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите минимальное значение: ");
int minV = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите максимальное значение: ");
int maxV = Convert.ToInt32(Console.ReadLine());

PrintArray(CRarray(size, minV, maxV));
