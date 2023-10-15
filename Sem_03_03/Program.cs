// Задача 3. По заданному № четверти показать диапазон координат x y в ней.

void FindFQ(int a)
{
    if(a==1) 
    {
        System.Console.WriteLine("Диапазон x+, y+");
    }
    else if(a==2) 
    {
        System.Console.WriteLine("Диапазон x-, y+");
    }
    else if(a==3) 
    {
        System.Console.WriteLine("Диапазон x-, y-");
    }
    else if(a==4) 
    {
        System.Console.WriteLine("Диапазон x+. y-");
    }
    else 
    {
        System.Console.WriteLine("Такой четверти не существует");
    }
}
System.Console.Write("Введи номер четверти: ");
int a = Convert.ToInt32(Console.ReadLine());
FindFQ(a);





