// 1. По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}