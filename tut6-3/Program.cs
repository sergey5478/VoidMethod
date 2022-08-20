/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.
[3 7 22 2 78] -> 76
*/
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double[] array = GetArray(5, 0, 100);
Console.WriteLine();
double maxnumber = 0;
double minnumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxnumber)
    {
        maxnumber = array[i];
    }
    else
    {
        if (array[i] < minnumber)
        {
            minnumber = array[i];
        }
    }
}
Console.WriteLine($"Разница между максимальным и минимальным: {maxnumber - minnumber}");