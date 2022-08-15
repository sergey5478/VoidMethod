// 26
//Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int getSumToA(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum++;
        number = number / 10;
    }
    return sum;
}
Console.WriteLine($"Количество чисел {getSumToA(num)}");