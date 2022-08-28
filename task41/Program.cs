/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
//Ввожу  случайные числа, распечатываю, 
//ищу положительные,вывожу количество.

int[] GetArray(int numberM, int minValue, int maxValue)
{
    int[] res = new int[numberM];
    for (int i = 0; i < numberM; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
void PrintArray(int[] print1)
{
    for (int i = 0; i < print1.Length; i++)
    {
        Console.Write($"{print1[i]} ");
    }
}
int[] array = GetArray(5, -100, 100);
PrintArray(array);
int amount = 0;
for (int i = 0; i < array.Length; i++)
{
        if (array[i] > 0)
    {
        amount += 1;
    }
}
Console.WriteLine($"Кол-во элементов> 0: {amount}");
