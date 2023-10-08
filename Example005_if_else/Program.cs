// Задача 005 про Если и Иначе
Console.Write("Введите имя пользователя ");
string username=Console.ReadLine();
if(username.ToLower()=="павел")
{
    Console.WriteLine("Павел, ты молодец !!!");
}
else
{
    Console.Write("Добрый день, ");
    Console.WriteLine(username);
}


