/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
Console.Clear();
Console.WriteLine("Введите начало промежутка M и завершение N");
int numberM = Convert.ToInt32(Console.ReadLine());
int namberN = Convert.ToInt32(Console.ReadLine());
string Number(int numberM, int namberN)
{
    if (numberM < namberN)
    {

        return $"{namberN} " + Number(numberM, namberN - 1);
    }
    else
    {
        return $"{numberM} ";
    }
}
Console.WriteLine(Number(numberM, namberN));
