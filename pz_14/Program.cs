namespace pz_14
{
    internal class Program
    {
        static int Zadanie_1(int a1,int d,int n)
        {
            int result;
            if (n == 1) return a1;            
            result = Zadanie_1(a1 + d, d, n - 1);
            return result;
        }
        private static double NthTerm(int v, int r, double t)
        {
            if (v == 1)
            {
                return r;
            }
            else if (v == 2)
            {
                return r * t;
            }
            else
            {
                return t * NthTerm(v - 1, r, t);
            }
        }
        static void Zadanie_3( int A, int B)
        {            
            if (A < B )
            {
                A--;
                Zadanie_3(A, B);
                Console.WriteLine(A);
            }
            else if(A > B)
            {
                B++;
                Zadanie_3(A, B);
                Console.WriteLine(B);
                
            }
            
        }

        static void Main(string[] args)
        {            
            Console.WriteLine("1 задание");
            Console.Write("Введите n член арифметической прогресии: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int q = 6;
            int e = 3;
            Console.WriteLine($"{n} член арифметической прогрессии равен: {Zadanie_1(q, e, n)}");
            Console.WriteLine();
            Console.WriteLine("Задание 2");
            int num = 3;
            Console.Write("Введите n-ый член геометрической прогрессии: ");
            int N = int.Parse(Console.ReadLine());
            double m = 0.15;
            double result = NthTerm(N, num, m);
            Console.WriteLine($"n-ный член прогрессии = {result}");
            Console.WriteLine();
            Console.WriteLine("3 задание");
            int a = 9;
            int b = -32-(+1);
            Zadanie_3(a, b);
        }
    }
}