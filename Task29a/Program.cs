// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6, 1, 33 -> [6,1,33]
Console.Clear();
int[] arr = new int[8];

Console.WriteLine("Введите 8 целых чисел для создания массива");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Вы создали массив:");
Console.Write(string.Join(", ", arr));