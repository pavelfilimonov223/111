// Семинар 3. Задача 1. На плоскости задаем координаты X и Y. Получаем
// номер четверти, где находиться эта точка.

int FindQ(int x, int y)
{
    if(x>0 && y>0) return 1;
    else if(x<0 && y>0) return 2;
    else if(x<0 && y<0) return 3;
    else if(x>0 && y<0) return 4;
    return 0; 
}
System.Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int q = FindQ(x,y);
System.Console.WriteLine(q);
