// 21. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
var array = new decimal[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Введите {0} число : ", i+1);
                array[i] = Convert.ToDecimal(Console.ReadLine());
            }
 
            var max = array[0];
            var min = array[0];
            for (int i = 1; i < 10; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
