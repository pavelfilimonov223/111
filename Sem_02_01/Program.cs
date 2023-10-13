// Вводим случайное 3х значное число. Удаляем вторую цифру этого числа.

void DelSecondDigit()
{
int randomNum = new Random().Next(100, 1000);
System.Console.WriteLine($"{randomNum} -> {randomNum/100 * 10 + randomNum % 10}");
}
DelSecondDigit();
