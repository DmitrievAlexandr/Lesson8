// Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов. (можно использовать 
//готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер 
//строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m, n];
Random random = new Random();
Console.WriteLine("Вывод массива.");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array2d[i, j] = random.Next(0, 10);
        Console.Write(array2d[i, j] + " ");
    }
    Console.WriteLine();
}

int[] arr = new int[m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i] += array2d[i, j];
    }
}

int min = arr[0];
int index = 0;
for (int i = 0; i < m; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
        index = i;
    }
}
Console.WriteLine($"строка {index+1} имеет наименьшую сумму элементов ");