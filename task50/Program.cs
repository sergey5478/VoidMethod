/*Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, 
что такого элемента нет.(на вход именно поступает позиция элемента, 
можете разбить на две переменные или прописать в одну строку и 
конвертировать в два числа, комментарии в конце семинара по этой задаче)

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/
Console.WriteLine("Введите позиции элемента в массиве A и B: ");
int coordinateA = Convert.ToInt32(Console.ReadLine());
int coordinateB = Convert.ToInt32(Console.ReadLine());
double[,] array = GetArray(4, 5, -10, 10);
PrintArray(array);
SearchElement(coordinateA, coordinateB);

double[,] GetArray(int lines, int columns, int min, int max)
{
    double[,] result = new double[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max) * new Random().NextDouble();
            result[i, j] = Math.Round(result[i, j], 2);
        }
    }
    return result;
}
void PrintArray(double[,] array)
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
void SearchElement(int ElementA, int ElementB)
{
    if (ElementA < array.GetLength(0) && ElementB < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента равно: {array[coordinateA, coordinateB]}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("такого элемента нет");
        Console.ResetColor();
    }
}