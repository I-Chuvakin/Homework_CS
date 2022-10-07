// Задача №6 
// Напишите программу, которая на вход принимает число 
// и выдает, является ли число чётным.
Console.Clear();
Console.Write("Введите значение числа: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0) 
  Console.WriteLine(a + " -число четное!");
else
  Console.WriteLine(a + " -число нечетное!");