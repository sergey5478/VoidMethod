﻿/*Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8
*/
Console.Clear();
Console.WriteLine("Введите a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Number(a, b));
string Number(int a, int b)
{
    if (a <= b)
    {
        return $"{a} " + Number(a + 1, b);
    }
    else
    {
        return String.Empty;
    }
}

