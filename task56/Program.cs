/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.
*/
int raws = 4;
int columns = 8;
int[,] array = GetArray(raws, columns);
PrintArray(array);
int k = 0;
int minSumRow = SumElements(array, 0);
Console.WriteLine(minSumRow);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumElements(array, i);
    if (minSumRow > tempSumRow)
    {
        minSumRow = tempSumRow;
        k = i;
    }
    Console.WriteLine(tempSumRow);
}
Console.WriteLine($"Строкa с индексом {k} с наименьшей суммой элементов {minSumRow} в массиве");

int SumElements(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum += array[i, j];
    }
    return sum;
}
int[,] GetArray(int raws, int columns)
{
    int[,] result = new int[raws, columns];
    for (int i = 0; i < raws; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}