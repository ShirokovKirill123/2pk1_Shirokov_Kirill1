namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            int h = m;
            while (h * 2 >= m)
            {
                m++;
                if (m % 2 != 0)
                {
                    res = res + m;
                    Console.WriteLine(res);
                }
            }
        }
    }
}