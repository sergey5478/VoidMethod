/*Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
Console.Clear();
Console.WriteLine("Введите a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(a));
int Sum(int a)
{
    if (a == 0) return 0;
    else return a % 10 + Sum(a / 10);
}
