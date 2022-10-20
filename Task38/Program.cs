// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
//  [3 7 22 2 78] -> 76 
Console.Clear();
double[] array = { -35, 3, 45, 69, 115 };
double result = 0;
double max = 0;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
result = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"min: {min}");
Console.WriteLine($"max: {max}");
Console.WriteLine($"Искомая разница между max и min: {result}");