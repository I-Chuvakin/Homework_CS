// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример [345, 897, 568, 234] -> 2  
Console.Clear();
Console.Write("Задайте длинну рандомного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
int j = 0;
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        j++;
    }
}
Console.WriteLine($"полученный рандомный массив: {string.Join(", ", array)}");
Console.WriteLine($"кол-во четных элементов: {j}");