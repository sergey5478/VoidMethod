/*Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.
*/
int raws = 4;
int columns = 8;
int[,] array = GetArray(raws,columns);
PrintArray(array);
Console.WriteLine();
DescendingLines(array);
PrintArray(array);
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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void DescendingLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}