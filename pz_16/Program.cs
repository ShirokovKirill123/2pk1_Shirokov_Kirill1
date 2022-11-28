namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"D:\pz_16\text1.txt"); //создаём файлы(допустим их будет 3)
            string dirName1 = @"D:\pz_16\text1.txt"; //создаём каталог с файлами
            File.Create(@"D:\pz_16\text2.txt");
            string dirName2 = @"D:\pz_16\text2.txt";
            File.Create(@"D:\pz_16\text3.txt");
            string dirName3 = @"D:\pz_16\text3.txt";
            if (File.Exists(@"D:\pz_16\text1.txt") && File.Exists(@"D:\pz_16\text2.txt") && File.Exists(@"D:\pz_15\text3.txt")) //Проверяем наши файлы на существование
            {
                Console.WriteLine("Deletion is being performed...");
                File.Delete(@"D:\text1.txt");
                File.Delete(@"D:\text2.txt");
                File.Delete(@"D:\text3.txt");
                Console.WriteLine("files delete");
            }
            else
            {
                Console.WriteLine("files not found");
            }
        }
    }
}