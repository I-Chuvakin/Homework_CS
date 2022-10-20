// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// Пример  [3, 7, 23, 12] -> 19 и [-4, -6, 89, 6] -> 0
Console.Clear();
int[] array = new int[6];
Random rand = new Random();
int res = 0;
int j = array.Length;
for (int i = 0; i < j; i++)
{
    array[i] = rand.Next(-9, 10);
}
for (int i = 1; i < j; i += 2)
{
    res = array[i] + res;
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма нечетых элементов длинной {j} массива = {res}");