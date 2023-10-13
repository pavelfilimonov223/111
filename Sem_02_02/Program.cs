// Принамаем на вход 2 числа, если второе не кратное первому, 
// то показываем остаток.

void Chek(int num1,int num2)
{
    if(num1 % num2 == 0)
    {
        System.Console.Write($"{num1},{num2}-> кратно ");
    }
    else
    {
       System.Console.Write($"{num1},{num2} -> НЕ кратно. Остаток {num1 % num2} "); 
    }
}
System.Console.Write("Введите число num1 = ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число num2 = ");
int num2 = Convert.ToInt32(Console.ReadLine());
Chek(int num1,int num2);

