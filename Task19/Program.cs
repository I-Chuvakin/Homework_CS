// Задачa 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом (симметрично читается в обоих направлениях)
// 14212 -> нет,  23432 -> да, 12821 -> да
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int backnumber = 0;

while (number > 0)
{
     int half = number % 10;
     backnumber = backnumber * 10 + half;
     number = number / 10;
 }
 if (number1 == backnumber)
     Console.WriteLine("Число является палиндромом");
 else
     Console.WriteLine("Число не является палиндромом");