/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
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

for (int i = 0; i < 12; i++)
{
    if (array[i] == num)
    {
        Console.WriteLine("Да");
        break;
    }
    else
    {
        int xcv = ($"Нет");
    }
    Console.WriteLine(xcv);
}
