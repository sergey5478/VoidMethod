/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/
Console.Clear();
int namberM = new Random().Next(1, 9);
int namberN = new Random().Next(10, 20);
int SumNumbers(int namberM, int namberN)
{
    if (namberM <= namberN)
    {
        if (namberM % 2 == 0)
        {
            return namberM + SumNumbers(namberM + 2, namberN);
        }
        else
        {
            namberM = namberM + 1;
            return namberM + SumNumbers(namberM + 2, namberN);
        }
    }
    else return 0;
}
Console.WriteLine($"{namberM} {namberN}");
Console.WriteLine(SumNumbers(namberM, namberN));