/*Задача 42: Напишите программу, которая будет 
преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/
//Без разворота числа получилось
Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int num = userNumber;
int remains = 0;

while (num > 0)
{
    remains = num % 2;
    Console.Write(remains);
    num = num / 2;
}

    