Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int number)
{
    int sum = 0;
    int i = 1;
    while(i<=number)
    {
        sum +=i;
        Console.Write($"{sum} ")
        i++;
    }
    return sum;
}
Console.WriteLine($"Сумма индексов чисел от 1 до А = {GetSumNums(num)}");//хрень