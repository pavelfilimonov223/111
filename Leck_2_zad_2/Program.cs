// Найти максимум из 9 ти чисел используя метод (функцию) и массив данных.

int[]array = {11,94,25,64,58,43,61,34,28};

int Max(int arg1,int arg2,int arg3)
{
int result = arg1;
if(arg2>result) result = arg2;
if(arg3>result) result = arg3;
return result;
}

int result = Max(
Max(array[0],array[1],array[2]),
Max(array[3],array[4],array[5]),
Max(array[6],array[7],array[8])
);
Console.WriteLine(result);


