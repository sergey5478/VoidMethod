Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

string s = "";
while (x > 0)
{
    s = ((x % 2 == 0) ? "0" : "1") + s;
    x /= 2;
}
Console.Write(s);
