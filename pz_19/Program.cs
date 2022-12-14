namespace pz_19
{
    internal class EnumTest
    {
        enum Marks
        {
            mark1 = 1,
            mark2 = 2,
            mark3 = 3,
            mark4 = 4,
            mark5 = 5,
        }
        enum Seasons
        {
            winter = 1,
            spring = 2,
            autumn = 3,
            summer = 4,
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Оценки по пятибальной шкале: 1, 2, 3, 4, 5");
                Console.WriteLine("Введите оценку:");
                int a = Convert.ToInt32(Console.ReadLine());
                Marks m = (Marks)a;
                TestMark(m);
                Console.WriteLine();
                Console.WriteLine("Введите время года(на английском):");
                string b = Convert.ToString(Console.ReadLine());
                Seasons f = (Seasons)Enum.Parse(typeof(Seasons), b);
                Seasons c = (Seasons)f;
                TestMark2(c);
                Console.WriteLine();
            }
        }
        static void TestMark(Marks a)
        {
            switch (a)
            {
                case Marks.mark1:
                    Console.WriteLine("очень плохо");
                    break;
                case Marks.mark2:
                    Console.WriteLine("неудовлетворительно");
                    break;
                case Marks.mark3:
                    Console.WriteLine("удовлетворительно");
                    break;
                case Marks.mark4:
                    Console.WriteLine("хорошо");
                    break;
                case Marks.mark5:
                    Console.WriteLine("отлично");
                    break;
                default:
                    Console.WriteLine("Вы ввели не ту оценку");
                    break;
            }
        }
        static void TestMark2(Seasons b)
        {
            switch (b)
            {
                case Seasons.winter:
                    Console.WriteLine("Праздники в этом месяце:");
                    Console.WriteLine(" 1, 2, 3, 4, 5, 6 и 8 января — Новогодние каникулы " +
                        "7 января — Рождество Христово" +
                        "23 февраля — День защитника Отечества");
                    break;
                case Seasons.spring:
                    Console.WriteLine("Праздники в этом месяце:");
                    Console.WriteLine("8 марта — Международный женский день" +
                        "1 мая — Праздник Весны и Труда" +
                        "9 мая — День Победы");
                    break;
                case Seasons.autumn:
                    Console.WriteLine("Праздники в этом месяце:");
                    Console.WriteLine("1 - сентябряДень знаний" +
                        "2 сентября - День российской гвардии" +
                        "3 сентября - День окончания Второй мировой войны");
                    break;
                case Seasons.summer:
                    Console.WriteLine("Праздники в этом месяце:");
                    Console.WriteLine("1 июня - Начало летних каникул" +
                        "1 июня - Первый день лета" +
                        "2 июня - День здорового питания");
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный месяц");
                    break;
            }
        }
    }
}