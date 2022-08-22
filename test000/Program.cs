// Console.WriteLine("Введите число ");
// int x = Convert.ToInt32(Console.ReadLine());

// string s = "";
// while (x > 0)
// {
//     s = ((x % 2 == 0) ? "0" : "1") + s;
//     x /= 2;
// }
// Console.Write(s);
/*Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.45 -> 1011013 -> 112 -> 10
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int i = 0;
while (number > 0)
{
    number = number / 2; //Считаем количество делений на 2 
    i++;
}
number = userNumber; //Возвращаем первоначальное значение 
int[] array = new int[i]; //Задаем массив нужного размера 
for (int j = 0; j < i; j++)
{
    array[j] = number % 2; //Заполняем его значениями 
    number = number / 2;
}
int[] ReversArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}
int[] reversArray = ReversArray(array); //Переворачиваем 
Console.Write($"Число {userNumber} в двоичной системе счисления равно ");

for (int j = 0; j < reversArray.Length; j++)
{
    Console.Write(reversArray[j]); //Выводим на экран
}

