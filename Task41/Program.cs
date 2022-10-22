// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine("Сколько чисел M будет введено?"); // Запрос в консоль на длинну массива
int m = Convert.ToInt32(Console.ReadLine());
void MArray(int[] array) // Метод на ввод М элементов
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите число №{index + 1}:");
        int N = Convert.ToInt32(Console.ReadLine());
        array[index] = N;
        index++;
    }
}
void PrintArray(int[] arr1)
{
    int count = arr1.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr1[index] + " ");
        index++;
    }
}

int[] array = new int[m];
MArray(array);
Console.WriteLine("вы ввели: ");
PrintArray(array);
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        res += 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"из них чисел больше 0 = {res}");