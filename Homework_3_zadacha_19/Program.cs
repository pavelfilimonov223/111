// ДЗ семинар 3. Задача 19. Принимает на вход 5ти значное число. И проверяет
// оно является или нет палиндромом (т.е. одинаковые цифры симметрично центру)

System.Console.WriteLine("Введите 5-ти значное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Пятая цифра {n} -> {n%10}");
System.Console.WriteLine($"Четвертая цифра {n} -> {(n%100-n%10)/10}");
System.Console.WriteLine($"Первая цифра {n} -> {(n-n%10000)/10000}");
System.Console.WriteLine ($"Вторая цифра {n} -> {(n%10000-n%1000)/1000}");

if ((n%10 == (n-n%10000)/10000) || (n%100-n%10)/10 == (n%10000-n%1000)/1000)
    {
       Console.WriteLine($"Число {n} -> ДА, это палиндром");
    }
        else
    {
       Console.WriteLine($"Число {n} -> НЕ является палиндромом");  
    }


