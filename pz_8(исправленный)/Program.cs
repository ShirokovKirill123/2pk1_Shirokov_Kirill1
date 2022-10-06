namespace pz_8_исправленный_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 8;
            int[,] A = new int[n, n];
            int[] C = new int[n];
            int[] S = new int[n];
            Random rand = new Random();

            Console.WriteLine(" Массив A: \n ");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    A[i, j] = rand.Next(1, 10);
                    Console.Write(" " + A[i, j]);
                }
                Console.WriteLine();
            }
            int[] vector1 = new int[8];
            int[] vector2 = new int[8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    if (i == j) vector1[i] = A[i, j];
                    else if (i == 8 - j - 1)
                        vector2[i] = A[i, j];
            }
            Console.WriteLine("\nПобочная диагональ:");

            foreach (double v in vector2) Console.Write(v + "\t");

            foreach (double v in vector2)
                Console.Write(v + "\t");


            int MaxV = 0;
            for (int i = 0; i < vector2.Length; i++)
            {
                if (vector2[i] > MaxV)
                    MaxV = vector2[i];
            }
            Console.WriteLine();
            Console.WriteLine($"\nМаксимальный элемент массива: {MaxV}");




            int ind1 = 0, ind2 = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (MaxV > A[i, j])
                    {
                        MaxV = A[i, j];
                        ind1 = i;
                        ind2 = j;
                    }
                    else
                        MaxV = MaxV;
                }
            }
            Console.WriteLine($"Максимальный элемент массива  с адресом [{ind1},{ind2}]");
        }
    }
}