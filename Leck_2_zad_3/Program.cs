// Задача 3. Есть массив, надо найти в нем элемент совпадающий с заданным значением,
//значение find, найти только первое совпадение с find и прекратить поиск.

int[]array = {2,12,18,43,36,28,43};
int n = array.Length;
int find = 43;
int index = 0;
while (index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
