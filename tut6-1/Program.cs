/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
int[] array = GetArray(5, 0, 1000);
Console.WriteLine();
int Sum =0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Sum += 1;
    }
}
Console.WriteLine(Sum);