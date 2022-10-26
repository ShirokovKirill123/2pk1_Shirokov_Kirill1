namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] A;
            A = new char[10];
            char maxChar = A[0];
            Console.WriteLine("Введём 10 символов массива! ");
            Console.WriteLine("Введите 1 символ массива: ");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 2 символ массива: ");
            char b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 3 символ массива: ");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 4 символ массива: ");
            char d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 5 символ массива: ");
            char e = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 6 символ массива: ");
            char f = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 7 символ массива: ");
            char g = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 8 символ массива: ");
            char h = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 9 символ массива: ");
            char k = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите 10 символ массива: ");
            char l = Convert.ToChar(Console.ReadLine());

            A[0] = a;
            A[1] = b;
            A[2] = c;
            A[3] = d;
            A[4] = e;
            A[5] = f;
            A[6] = g;
            A[7] = h;
            A[8] = k;
            A[9] = l;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxChar)
                    maxChar = A[i];
            }
            Console.WriteLine($"Максимальный элемент массива: {maxChar}");

            var sort = A.OrderBy(i => i);
            Console.WriteLine("\nЭлементы в порядке возрастания: ");
            foreach (var i in sort)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }
    }
}