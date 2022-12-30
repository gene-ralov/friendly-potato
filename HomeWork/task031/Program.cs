// 31. Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
static void Main(string[] args) 
    {
        int[,] m1 = new int[3, 3];
        int[,] m2 = new int[3, 3];
        int[,] m3 = new int[3, 3];
        Random ran = new Random();
        for (int m = 0; m < 3; m++) 
        {

            for (int je = 0; je < 3; je++) 
            {
                m1[m, je] = ran.Next(10); // ran.Next(максимально допустимое значение);
                m2[m, je] = ran.Next(10);
            }
        }

        for (int m = 0; m < 3; m++) 
        {
            for (int je = 0; je < 3; je++) 
            {
                m3[m, je] = m1[m, je] * m2[m, je]; // Произведение матриц
            }
        }

        Console.WriteLine("Произведение двумерных матриц m1 и m2:");
        for (int i = 0; i < 3; i++) 
        {
            for (int j = 0; j < 3; j++) 
            {
                Console.Write(m3[i, j] + " "); // вывод в консоль
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
