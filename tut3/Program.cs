/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int unknown = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == num)
    {
        unknown = 1;
        break;
    }
    else
    {
        unknown = 2;
    }
}
if (unknown == 1)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}