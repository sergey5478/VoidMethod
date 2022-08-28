/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
// Вводим 5 чисел
// ищу положительные,вывожу количество.
Console.WriteLine("Введите 5 чисел: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double b3 = Convert.ToDouble(Console.ReadLine());
double b4 = Convert.ToDouble(Console.ReadLine());
double b5 = Convert.ToDouble(Console.ReadLine());
int amount = 0;
if(b1>0) amount+=1;
if(b2>0) amount+=1;
if(b3>0) amount+=1;
if(b4>0) amount+=1;
if(b5>0) amount+=1;
Console.WriteLine($"Кол-во элементов>0: {amount}");