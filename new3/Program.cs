// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();
Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
int GetWork(int number)
{
    int work = 1;
    int i = 1;
    while(i<=number)
    {
        work *=i;
        Console.Write($"{work} ");
        i++;
    }
    return work;
}
Console.WriteLine($"Произведение чисел от 1 до N = {GetWork(num)}");