// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
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
Console.WriteLine("введите число строк и столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] F = Array(m, n);
Console.WriteLine("Введите номер строки и столбца элемента массива");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if ((x > m) | (y > n)) Console.WriteLine("Такой позиции нет в этом массиве");
else Console.WriteLine($"F [{x}, {y}] = {F[x-1, y-1]}");