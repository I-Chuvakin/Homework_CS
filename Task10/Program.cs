// Задача 10. Напишите программу, кот. принимает на вход 3-х значн. число.
// и на выходе показывает вторую цифру этого числа. 
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int aaa = Convert.ToInt32(Console.ReadLine());
if (aaa >= 100 & aaa < 1000)
{
   int b = aaa / 10;
   int c = b % 10;
   Console.WriteLine($"Вторая цифра числа {aaa} : {c}");
}
else 
{
    Console.WriteLine("повторите попытку, введено некорректное число");
}