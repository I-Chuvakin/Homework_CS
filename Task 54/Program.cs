// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int[,] Array(int m, int n)
{
    int[,] F = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            F[i, j] = new Random().Next(-100, 100);
            Console.Write("{0, 6}", F[i, j]);
        }
        Console.WriteLine();
    }
    return F;
}
void PrintArray(int[,] F)
{
    for (int i = 0; i < F.GetLength(0); i++)
    {
        for (int j = 0; j < F.GetLength(1); j++)
        {
            Console.Write("{0, 6}", F[i, j]);
        }
        Console.WriteLine();
    }
}
void SortRows(int[,] F)
{
    for (int i = 0; i < F.GetLength(0); i++)
    {
        for (int j = 0; j < F.GetLength(1) - 1; j++)
        {
            if (F[i, j] < F[i, FindMax(F, i, j + 1)])
            {
                int temp = F[i, j];
                F[i, j] = F[i, FindMax(F, i, j + 1)];
                F[i, FindMax(F, i, j + 1)] = temp;
            }
        }
    }
}
int FindMax(int[,] F, int k, int l)
{
    int maxNum = l;
    int max = F[k, l];
    for (int i = l + 1; i < F.GetLength(1); i++)
    {
        if (F[k, i] > max)
        {
            maxNum = i;
            max = F[k, i];
        }
    }
    return maxNum;
}
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] F = Array(m, n);
Console.WriteLine("новый массив:");
SortRows(F);
PrintArray(F);