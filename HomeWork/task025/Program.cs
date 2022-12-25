// 25. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Write("Введите число: ");
int value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine($"В двоичном будет: {binary}");
            Console.ReadLine();