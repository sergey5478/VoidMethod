/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
Console.WriteLine("Введите число A и B:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int power = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Pow(userNumber, power));
int Pow(int userNumber, int power)
{
    if (power == 0) return 1;
    else return Pow(userNumber, power - 1) * userNumber;
}