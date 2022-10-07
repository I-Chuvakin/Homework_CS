// Задача №4 
Console.Clear();
Console.Write("Введите значение 1го натурального числа: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2го натурального числа: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 3го натурального числа: ");
int c = Convert.ToInt32(Console.ReadLine());

int Max_Result = a;
if (b > Max_Result) Max_Result = b;
if (c > Max_Result) Max_Result = c;
Console.WriteLine("Максимальное число из 3х: " + Max_Result);