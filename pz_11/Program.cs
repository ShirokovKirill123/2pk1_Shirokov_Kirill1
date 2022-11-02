namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово первой строки:");
            string text1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе слово первой строки:");
            string text2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите третье слово первой строки:");
            string text3 = Convert.ToString(Console.ReadLine());
            string newText = text1 + " " + text2 + " " + text3;
            Console.WriteLine("Полученная первая строка:");
            Console.WriteLine($"{newText}\n");           
            string text4 = string.Copy(text1);            
            string text5 = string.Copy(text2);
            Console.WriteLine("Введите третье слово второй строки:");
            string text6 = Convert.ToString(Console.ReadLine());
            string newText2 = text4 + " " + text5 + " " + text6;
            Console.WriteLine("Полученная вторая строка:");
            Console.WriteLine($"{newText2}\n");
            if (text1 == text4 && text2 == text5)
            {
                newText2 = text6;                
            }
            Console.WriteLine($"Полученная первая строка:{newText}");
            Console.WriteLine($"Полученная вторая строка:{newText2}");
        }
    }
}