// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] Array(int m, int n)
{
    int[,] F = new int[m, n];
    for (int i= 0; i < m; i++)
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
Console.WriteLine("введите n число строк и m число столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] F = Array(m, n);
for (int j = 0; j < F.GetLength(1); j++)
{
    double res = 0;
    for (int i = 0; i < F.GetLength(0); i++)
    {
        res += F[i, j];
    }
    res /= F.GetLength(0);
   Console.WriteLine(" * среднее арифметическое элементов столбца №{0,7}: {1:#.##}", j, res);
}    
