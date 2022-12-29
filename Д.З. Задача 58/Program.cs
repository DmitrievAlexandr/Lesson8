// Задайте две матрицы. Напишите программу, которая будет находить 
//произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//8 20
//15 18

Console.WriteLine("Введите размерность 1 матрицы ");
int m1 = Convert.ToInt32(Console.ReadLine());
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размерность 2 матрицы ");
int m2 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 != m2)
{
    Console.WriteLine("столбцы 1 матрицы не равны строкам 2 матрицы, умножение невозможно");
    Environment.Exit(0);
}

int[,] array1 = new int[m1, n1];
int[,] array2 = new int[m2, n2];

FillArray(array1);
Console.WriteLine("первая матрица :");
PrintArray(array1);
FillArray(array2);
Console.WriteLine("вторая матрица :");
PrintArray(array2);
var array3 = Multiply(array1, array2);
Console.WriteLine("результат умножения матриц :");
PrintArray(array3);

int[,] Multiply(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < n1; k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            array3[i, j] = sum;
        }
    }
    return array3;
}


void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
