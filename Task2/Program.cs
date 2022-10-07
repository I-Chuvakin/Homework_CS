// Задача №2 
// Напишите программу, котор. на вход принимает 2 числа и выдает
// какое число большее.
Console.Clear();
Console.Write("Введите значение 1го числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2го числа: ");
int b = Convert.ToInt32(Console.ReadLine());

int Max_Result = a;
if (b > Max_Result) Max_Result = b;
Console.WriteLine("Максимальное число из пары чисел: " + Max_Result);