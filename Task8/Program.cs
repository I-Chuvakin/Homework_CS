// Задача 8 
// Напишите программу, котор. на вход принимает число N, а на выходе
// показывает все чётные от нуля до N
Console.Clear();
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2;  i <= n; i=2 + i)
{
    if (i % 2 ==0)
    Console.Write(i + " ");
}
