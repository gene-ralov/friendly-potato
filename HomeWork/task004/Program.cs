// 4. Выяснить является ли число чётным.
Console.Write("Введите число для проверки: ");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine("Чётное");
}
else
{
    Console.WriteLine("Нечётное");
}
