// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
//  элементов: 1 строка 
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
Console.WriteLine("Введите количество строк и столбцов массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] F = Array(m, n);
int SumRow(int k)
{
    int sum = 0;
    for (int i = 0; i < F.GetLength(1); i++)
    {
        sum += F[k, i];
    }
    return sum;
}
int MinSum = SumRow(0);
int MinRow = 0;
for (int i = 1; i < F.GetLength(0); i++)
{
    if (SumRow(i) < MinSum)
    {
        MinRow = i;
        MinSum = SumRow(i);
    }
}
Console.WriteLine($"минимальная сумма в {MinRow + 1}-й строке");