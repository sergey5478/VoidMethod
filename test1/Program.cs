void RandomArray(int[] array)//Метод подсчета 
{
    for (int i = 0; i < a.Length; i++)//цикл прогона через весь массив/сравнение с 
    //длиной массива 
    {
        array[i]=new Random().Next(1, 100); //блок рандома который принимает 
        Console.Write($"{array[i]} ");//Вывод на экран
    }
}
