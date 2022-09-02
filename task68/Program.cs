/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 29
*/
//Console.Clear();
int m = 3;
int n = 2;
int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
int Ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (n == 0)
        {
            return Ack(m - 1, 1);
        }
        else
        {
            return Ack(m - 1, Ack(m, n - 1));
        }
    }
}