// See https://aka.ms/new-console-template for more information
// 3. Найти максимальное из трех чисел
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;

if (a > b && a > c)
{
max = a;
}
else if (b > a && b > c)
{
max = b;
}
else
{
max = c;
}
Console.Write("Максимальное число: ");
Console.WriteLine(max);