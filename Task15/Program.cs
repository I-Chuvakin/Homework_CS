// Задача 15. Напишите программу, котор. приннимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. Прим. 6-> да, 7 -> да, 1 -> нет. 
Console.Clear();
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num < 1) | (num > 7))
{
    Console.WriteLine("некорректный номер");
}
else
{
    if ((num == 6) | (num == 7))
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}