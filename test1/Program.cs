void RandomArray(int[] array)//Метод подсчета 
{
    for (int i = 0; i < array.Length; i++)//цикл прогона через весь массив/сравнение с 
    //длиной массива 
    {
        array[i]=new Random().Next(1, 100); //блок рандома который принимает 
        Console.Write($"{array[i]} ");//Вывод на экран
    }
}
// int[] arr =  new int [6];  // Можно задать переменную заранее
// RandomArray(arr);

RandomArray(new int [6]); //или прям в скобках