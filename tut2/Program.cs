/*Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] array1 = new int[array.Length];
int j = 0;

foreach (int i in array)
{
    if (i > 0)
    {
        array1[j] = i * -1;
        j++;
    }
    else
    {
        array1[j] = i * -1;        
        j++;
    }
    Console.Write($"{array1[j-1]} ");
}