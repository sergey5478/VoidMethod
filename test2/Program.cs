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
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(5, -1, 2);
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    array[i] = array [i] * -1;
    Console.Write($"{array[i]} ");
}   
