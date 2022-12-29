// Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива. (можно использовать 
//готовую функцию)
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.WriteLine("Ведите строку m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите столбцы  n");
int n = Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int[m, n];
int [,] array = new int[m, n];
int [] arr = new int [n];
Random random = new Random();
Console.WriteLine("Вывод массива");
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next (1,20);
        Console.Write(array2d[i,j]+" ");
        arr[j]=array2d[i,j];
    }
    Console.WriteLine();
    Array.Sort(arr);Array.Reverse(arr);
    for (int j = 0; j <arr.Length; j++)
    {
        array[i,j]=arr[j];
    }
} 
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i,j]+" ");    
    }
    Console.WriteLine();
}