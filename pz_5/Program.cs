namespace pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 задание");
            for (int i = 30; i <= 150; i += 15)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("3 задание");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine('#');
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("4 задание");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 18 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("5 задание");
            int k = 0;

            int j = 35;

            for (int i = 0; i < 100; i++)
            {
                k++;
                Console.WriteLine(k);
                j--;
                Console.WriteLine(j);
                if (j - k == 3)
                {
                    Console.WriteLine("разница 3");
                    break;
                }
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("2 задание");
            char n = 'н';

            for (int i = 0; i < 5; i++)
            {
                Console.Write(n + " ");
                n++;
            }
        }
    }
}