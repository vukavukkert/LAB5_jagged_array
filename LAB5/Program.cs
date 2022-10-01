using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            //создать массив массивов. 1. объект рандом. 2. инициализция четырех мерный массив с случайным количеством длины(от 2 до 20). 3. заполнить массив случаными числами(от 0 до 100)
            // вывести колчество всех чисел кратных 10. сколько нулей сколько 20 сколько 10 сколько 30
            Random rand = new Random(DateTime.Now.Millisecond);
            int n1 = rand.Next(2, 21);
            int n2 = rand.Next(2, 21);
            int n3 = rand.Next(2, 21);
            int n4 = rand.Next(2, 21);
            int[] result = new int[11];
            int[,,,] array = new int[n1, n2, n3, n4];

            //цикл который когда отрабатывает меняет массив
            for (int x1 = 0; x1 < n1; x1++)
            {
                for (int x2 = 0; x2 < n2; x2++)
                {
                    for (int x3 = 0; x3 < n3; x3++)
                    {
                        for (int x4 = 0; x4 < n4; x4++)
                        {
                            array[x1, x2, x3, x4] = rand.Next(0, 101);
                        }
                    }
                }
            }
            foreach (int i in array)
            {
                if (i % 10 == 0)
                {
                    if (i == 0) result[0] = result[0] + 1;
                    else if (i == 10) result[1] = result[1] + 1;
                    else if (i == 20) result[2] = result[2] + 1;
                    else if (i == 30) result[3] = result[3] + 1;
                    else if (i == 40) result[4] = result[4] + 1;
                    else if (i == 50) result[5] = result[5] + 1;
                    else if (i == 60) result[6] = result[6] + 1;
                    else if (i == 70) result[7] = result[7] + 1;
                    else if (i == 80) result[8] = result[8] + 1;
                    else if (i == 90) result[9] = result[9] + 1;
                    else if (i == 100) result[10] = result[10] + 1;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{i * 10} - {result[i]}");

            }
        }
    }
}
