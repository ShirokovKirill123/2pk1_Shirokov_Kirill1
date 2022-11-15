namespace pz_12
{
    internal class Program
    {                   
            static void RootsCount( out int A,  out int B,  out int C)
            {
                Console.WriteLine("Введите вещественное значение a:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вещественное значение b:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите вещественное значение c:");
                double c = Convert.ToDouble(Console.ReadLine());
                double D = (b * b) - 4 * a * c;
                if (D > 0)
                {
                    A = 2;
                }
                else if (D == 0)
                {
                    A = 1;
                }
                else
                {
                    A = 0;                    
                }
                Console.WriteLine("Введите второе вещественное значение a:");                           
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе вещественное значение b:");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе вещественное значение c:");
                double c1 = Convert.ToDouble(Console.ReadLine());
                double D1 = (b1 * b1) - 4 * a1 * c1;
                if (D1 > 0)
                {
                    B = 2;
                }
                else if (D1 == 0)
                {
                    B = 1;
                }
                else
                {
                    B = 0;
                }

                Console.WriteLine("Введите третье вещественное значение a:");                
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третье вещественное значение b:");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите третье вещественное значение c:");
                double c2 = Convert.ToDouble(Console.ReadLine());
                double D2 = (b2 * b2) - 4 * a2 * c2;
                if (D2 > 0)
                {
                    C = 2;
                }
                else if (D2 == 0)
                {
                    C = 1;
                }
                else
                {
                    C = 0;
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Квадратное уравнение имеет вид: ax^2 + bx + c = 0");
                int A, B, C;
                RootsCount(out A, out B, out C);
                Console.WriteLine($"A имеет {A} корня(-ней),B имеет {B} корня(-ней),C имеет {C} корня(-ней)");
            }        
    }
}