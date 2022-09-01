/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/
int raws = 2;
int columns = 2;
int[,] array1 = GetArray(raws, columns);
int[,] array2 = GetArray(raws, columns);
int[,] resultMatrix = new int[raws, columns];
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] SumMatrix = ArrayMatrix(array1, array2, resultMatrix);
PrintArray(SumMatrix);
int[,] ArrayMatrix(int[,] array1, int[,] array2, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
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