namespace pz_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                double a = 10;
                byte* x = (byte*)&a;
                x[0] = 1;
                x[1] = (byte)'A';
                x[2] = (byte)'A';
                x[3] = 2;
                x[4] = 2;
                x[5] = 2;
                x[6] = 2;
                x[7] = 3;

                Console.WriteLine("  Адрес    |   Значение");
                Console.WriteLine($"{(uint)&x[0]}  | \t {x[0]}");
                Console.WriteLine($"{(uint)&x[1]}  | \t {(char)x[1]}");
                Console.WriteLine($"{(uint)&x[2]}  | \t {(char)x[2]}");
                Console.WriteLine($"{(uint)&x[3]}  | \t {x[3]}");
                Console.WriteLine($"{(uint)&x[4]}  | \t {x[4]}");
                Console.WriteLine($"{(uint)&x[5]}  | \t {x[5]}");
                Console.WriteLine($"{(uint)&x[6]}  | \t {x[6]}");
                Console.WriteLine($"{(uint)&x[7]}  | \t {x[7]}");
            }
        }
    }
}