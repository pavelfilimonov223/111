// Выводим случайное число из отрезка от 10 до 99 и показываем 
// наибольшую цифру числа.

int FBD(int num)
{
int ed = num % 10;
int dec = num / 10;
if(dec < ed) return ed;
else return dec;
}
int randomNum = new Random().Next(10,99+1);
int biggerD = FBD(randomNum);
System.Console.WriteLine($"{randomNum} -> {biggerD}");

