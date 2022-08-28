﻿/*Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
//Пользователь вводит 4 числа, из формулы находим х, потом y
//незабываем, что прямые пересякаются при k1=k2
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
if (k1!=k2)
{
    double x = (b2 - b1)/(k1 - k2);
    Console.WriteLine($"Координаты точки пересечения двух прямых({x};{k1 * x + b1})");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}