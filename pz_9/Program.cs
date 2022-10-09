namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[][] A = new double[10][];
            for (int i = 0; i < 10; i++)
            {
                A[i] = new double[random.Next(3,31)];
            }
            Console.WriteLine("Полученный массив:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = random.Next(-99, 99);
                    Console.Write($"{A[i][j]} ");
                }
                Console.WriteLine($"\n");
            }
            Console.WriteLine();

            double[][] a = A;
            double[] b = new double[a.GetLength(0)];
            double[] MaxS = new double[a.GetLength(0)];
            double c;
            double[] averageN = new double[a.GetLength(0)];
            int ind1 = 0;
            int ind2 = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                c = a[i][0];
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > c)
                    {
                        averageN[i] += a[i][j];
                        c = a[i][j];
                        ind1 = i;
                        ind2 = j;
                    }
                }
                averageN[i] /= a[i].Length;
                MaxS[i] = c;
                b[i] = a[i][a[i].Length - 1];
                c = a[i][0];
                a[i][0] = a[ind1][ind2];
            }

            Console.WriteLine($"Массив с последними элементами из каждой строки ступенчатого массива: \n");
            for (int e = 0; e < b.Length; e++)
            {
                Console.Write($"{b[e]} \t");
            }
            Console.WriteLine();
            Console.WriteLine($"\nМассив с максимальными элементами из каждой строки ступенчатого массива: \n");
            for (int r = 0; r < MaxS.Length; r++)
            {
                Console.Write($"{MaxS[r]} \t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Массив после замены первого элемента в строке и максимального: \n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]} ");
                }
                Console.WriteLine($"\n");
            }
            Console.WriteLine($"\nРеверс обновлённого ступенчатого массива: \n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Array.Reverse(a[i]);
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]} ");
                }
                Console.WriteLine($"\n");
            }
            Console.WriteLine($"\nСреднее число в каждой строке ступенчатого массива: \n");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write($"{averageN[i]} \t");
            }
        }
    }
}