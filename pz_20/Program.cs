using System.Text.RegularExpressions;
namespace pz_20
{
    internal class Program
    {
        static void Zadanie_2()
        {
            FileStream file1 = new FileStream("F:\\connects.log", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file1);
            string text = "213.180.195.231 - - [29/Jan/2007:00:07:17 +0000] \"GET /excel/lsn015.html HTTP/1.1\" 200 18918 \"-\r\n\" \"YaDirectBot/1.0" +
            "\"\r\n74.6.71.37 - - [29/Jan/2007:00:13:03 +0000] \"GET /eralash HTTP/1.0\" 301 317 \"-\" \"Mozilla/5.0 \r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)" +
            "\"\r\n74.6.71.37 - - [29/Jan/2007:00:13:06 +0000] \"GET /eralash/ HTTP/1.0\" 200 12234 \"-\" \"Mozilla/5.0\r\n(compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)" +
            "\"\r\n213.186.116.166 - - [29/Jan/2007:00:26:51 +0000] \"GET /eralash/soft/speed.zip HTTP/1.0\" 200 \r\n217872 \"-\" \"Wget/1.10.2 (Red Hat modified)" +
            "\"\r\n213.180.207.25 - - [29/Jan/2007:00:27:14 +0000] \"GET /robots.txt HTTP/1.1\" 200 54 \"-\" \r\n\"Yandex/1.01.001 (compatible; Win16; I)\"";
            writer.Write(text);
            writer.Close();
            FileStream file2 = new FileStream("F:\\connects.log", FileMode.Open);
            StreamReader reader = new StreamReader(file2);
            reader.ReadToEnd();
            reader.Close();
            string pattern1 = @"(\d+[.]\d+[.]\d+[.]\d+\s)";
            Regex regex1 = new Regex(pattern1);
            Console.WriteLine("IP:");
            foreach(Match match in regex1.Matches(text))
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("Dates:");
            string pattern2 = @"(\d+[/]\w+[/]\d+)";
            Regex regex2 = new Regex(pattern2);
            foreach (Match match in regex2.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }
        static void Zadanie_1()
        {
            string text = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76" +
            "\r\n2 RU161110-466130 PACK19651968 1 Софья Назаретян +7 (918) 398-07-81 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61" +
            "\r\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52" +
            "\r\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19" +
            "\r\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19" +
            "\r\n6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00 \r\nКраснодар, фурманова, Дом 62 9.11";
            string pattern1 = @"Ольга Каверзина";
            string pattern2 = @"Софья Назаретян";
            string pattern3 = @"Виктор Кипуров";
            string pattern4 = @"Ирина Концевик";
            string pattern5 = @"Ирина Концевик";
            string pattern6 = @"Роман";

            Regex regex1 = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);
            Regex regex3 = new Regex(pattern3);
            Regex regex4 = new Regex(pattern4);
            Regex regex5 = new Regex(pattern5);
            Regex regex6 = new Regex(pattern6);

            foreach (Match match in regex1.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex2.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex3.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex4.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex5.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex6.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }
        static void Zadanie_1_2Way()
        {
            string text = "1 RU161109-472905 PACK19697671 1 Ольга Каверзина +7 (918) 335-43-52 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, красина, Дом 3/3, Кв. 76" +
            "\r\n2 RU161110-466130 PACK19651968 1 Софья Назаретян +7 (918) 398-07-81 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, Базовская, Дом д.61" +
            "\r\n3 RU161111-260536 PACK19698066 3 Виктор Кипуров +7 (918) 441-97-56 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, Речная,Чехова , Дом 4, Кв. 52" +
            "\r\n4 RU161111-522664 PACK19697905 2 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19" +
            "\r\n5 RU161111-252357 PACK19697840 1 Ирина Концевик +7 (918) 045-77-00 Наличные Плюс 0 \r\n09:00 - 13:00 Краснодар, ул им Братьев Дроздовых, Дом 41, Кв. 19" +
            "\r\n6 RU161104-298585 PACK19514804 3 Роман +7 (938) 435-93-29 Наличные Плюс 0 09:00 - 13:00 \r\nКраснодар, фурманова, Дом 62 9.11";
            string pattern1 = @"([А-Я][а-я]+\s?[А-Я][а-я]{1,})\s[+7]";
            string pattern2 = @"[3]\s([А-Я][а-я]+)\s[+7]";
            Regex regex = new Regex(pattern1);
            Regex regex2 = new Regex(pattern2);
            foreach (Match match in regex.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
            foreach (Match match in regex2.Matches(text))
            {
                Console.WriteLine(match.Value);
            }
        }
            static void Main(string[] args)//Задание_1
        {
            Zadanie_1_2Way();
        }
    }
}