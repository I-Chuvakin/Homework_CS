// Задача 13. Напишите программу, котор. выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Clear();
Console.Write("Введите трёхзначное число, или более: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = -404;
if (number < 100)
{
      Console.WriteLine("Третьей цифры нет!");
}
else 
while (number >= 100)
{
    a = number % 10;
    number = number / 10;
}
Console.WriteLine($"Третья цифра числа: {a}");