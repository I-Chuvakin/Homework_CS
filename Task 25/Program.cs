// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 это: (3^5) (i^j)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int i;
int sum = 1;
for (i = 1; i <= B; i++)
{
    sum = A * sum;
}
Console.WriteLine($"Ответ: {A} в степени {B} равно {sum}");