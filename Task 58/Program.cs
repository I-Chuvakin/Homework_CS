// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int[,] Array(int m, int n)
{
    int[,] F = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            F[i, j] = new Random().Next(-10, 10);
            Console.Write("{0, 6}", F[i, j]);
        }
        Console.WriteLine();
    }
    return F;
}
Console.WriteLine("Введите количество строк и столбцов первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] F = Array(m, n);
Console.WriteLine("Введите количество строк и столбцов второй матрицы");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int[,] b = Array(x, y);
if (n != x) Console.WriteLine("произведение матриц невозможно");
else
{
    Console.WriteLine("произведение матриц:");
    int[,] c = new int[m, y];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < y; j++)
        {
            c[i, j] = MatrixComposition(i, j);
            Console.Write("{0, 6}", c[i, j]);
        }
        Console.WriteLine();
    }
}
int MatrixComposition(int k, int l)
{
    int num = 0;
    for (int i = 0; i < F.GetLength(1); i++)
    {
        num += F[k, i] * b[i, l];
    }
    return num;
}