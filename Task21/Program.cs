// Задача 21. Напишите программу, которая принимает на вход координаты 2-х точек и находит 
// расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7), -> 15.84
// A(7,5,1); B(1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки A по x");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки A по y");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по x");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по y");
double yB = Convert.ToDouble(Console.ReadLine());
double res = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
Console.WriteLine($"{res:f2}");