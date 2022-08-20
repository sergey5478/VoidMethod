// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void LenNumber(int arr)//выводит массив из указанного числа элементов(использует функцию)
// {
//     int[] ArrayM = new int[arr];
//     for (int i = 0; i < ArrayM.Length; i++)
//     {
//         ArrayM[i] = new Random().Next(0, 2);
//         Console.Write($"{ArrayM[i]} ");
//     }
// }
// LenNumber(20);

int[] ArrayM = new int[8]; // выводит массив ровно из 8 элементов
for (int i = 0; i < ArrayM.Length; i++)
{
    ArrayM [i]= new Random().Next(0, 2);
    Console.Write($"{ArrayM[i]} ");
}