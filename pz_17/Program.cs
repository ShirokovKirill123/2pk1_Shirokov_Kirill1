namespace pz_17
{
    internal class Program
    {
        public static void GenerateMap(ref char[,] map, ref char P, ref char e1, ref char e2, ref char e3, ref char e4, ref char e5, ref char e6, ref char e7, ref char e8, ref char e9, ref char e10, ref char e11, ref char h1, ref char h2, ref char h3, ref char h4, ref char h5, ref char b1, ref char b2, ref char b3, ref char b4, ref char b5)//генерация карты
        {
            map = new char[25, 25];
            P = 'P';
            int r = 0;
            int steps = 0;
            int power = 5;
            int HP = 31;
            int HP1 = 15;
            int power1 = 5;
            int HP2 = 15;
            int power2 = 5;
            int HP3 = 15;
            int power3 = 5;
            int HP4 = 15;
            int power4 = 5;
            int HP5 = 15;
            int power5 = 5;
            int HP6 = 15;
            int power6 = 5;
            int HP7 = 15;
            int power7 = 5;
            int HP8 = 15;
            int power8 = 5;
            int HP9 = 15;
            int power9 = 5;
            int HP10 = 15;
            int power10 = 5;
            int HP11 = 30;
            int power11 = 7;
            Healing(ref h1, ref h2, ref h3, ref h4, ref h5);
            Buff(ref b1, ref b2, ref b3, ref b4, ref b5);
            Random rnd = new Random();
            int x1 = rnd.Next(0, 25);
            int y1 = rnd.Next(0, 25);
            int x2 = rnd.Next(0, 25);
            int y2 = rnd.Next(0, 25);
            int x3 = rnd.Next(0, 25);
            int y3 = rnd.Next(0, 25);
            int x4 = rnd.Next(0, 25);
            int y4 = rnd.Next(0, 25);
            int x5 = rnd.Next(0, 25);
            int y5 = rnd.Next(0, 25);
            int x6 = rnd.Next(0, 25);
            int y6 = rnd.Next(0, 25);
            int x7 = rnd.Next(0, 25);
            int y7 = rnd.Next(0, 25);
            int x8 = rnd.Next(0, 25);
            int y8 = rnd.Next(0, 25);
            int x9 = rnd.Next(0, 25);
            int y9 = rnd.Next(0, 25);
            int x10 = rnd.Next(0, 25);
            int y10 = rnd.Next(0, 25);
            int x11 = rnd.Next(0, 25);
            int y11 = rnd.Next(0, 25);
            Random rnd2 = new Random();
            int x1h = rnd.Next(0, 25);
            int y1h = rnd.Next(0, 25);
            int x2h = rnd.Next(0, 25);
            int y2h = rnd.Next(0, 25);
            int x3h = rnd.Next(0, 25);
            int y3h = rnd.Next(0, 25);
            int x4h = rnd.Next(0, 25);
            int y4h = rnd.Next(0, 25);
            int x5h = rnd.Next(0, 25);
            int y5h = rnd.Next(0, 25);

            int x1b = rnd.Next(0, 25);
            int y1b = rnd.Next(0, 25);
            int x2b = rnd.Next(0, 25);
            int y2b = rnd.Next(0, 25);
            int x3b = rnd.Next(0, 25);
            int y3b = rnd.Next(0, 25);
            int x4b = rnd.Next(0, 25);
            int y4b = rnd.Next(0, 25);
            int x5b = rnd.Next(0, 25);
            int y5b = rnd.Next(0, 25);
            e1 = 'E';
            e2 = 'E';
            e3 = 'E';
            e4 = 'E';
            e5 = 'E';
            e6 = 'E';
            e7 = 'E';
            e8 = 'E';
            e9 = 'E';
            e10 = 'E';
            e11 = 'S';
            int k = 12;
            int l = 12;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[k, l] = P;
                    if ((i == x1h && j == y1h))
                    {
                        map[i, j] = h1;
                    }
                    else if ((i == 12 && j == 12))
                    {
                        map[i, j] = h1;
                    }
                    else if (i == x2h && j == y2h)
                    {
                        map[i, j] = h2;
                    }
                    else if ((i == x1h && j == y1h) || (i == 12 && j == 12))
                    {
                        map[i, j] = h2;
                    }
                    else if (i == x3h && j == y3h)
                    {
                        map[i, j] = h3;
                    }
                    else if ((i == x1h && j == y1h) || (i == x2h && j == y2h) || (i == 12 && j == 12))
                    {
                        map[i, j] = h3;
                    }
                    else if (i == x4h && j == y4h)
                    {
                        map[i, j] = h4;
                    }
                    else if ((i == x1h && j == y1h) || (i == x2h && j == y2h) || (i == x3h && j == y3h) || (i == 12 && j == 12))
                    {
                        map[i, j] = h4;
                    }
                    else if (i == x5h && j == y5h)
                    {
                        map[i, j] = h5;
                    }
                    else if ((i == x1h && j == y1h) || (i == x2h && j == y2h) || (i == x3h && j == y3h) || (i == x4h && j == y4h) || (i == 12 && j == 12))
                    {
                        map[i, j] = h5;
                    }


                    else if ((i == x1b && j == y1b))
                    {
                        map[i, j] = b1;
                    }
                    else if ((i == 12 && j == 12))
                    {
                        map[i, j] = b1;
                    }
                    else if (i == x2b && j == y2b)
                    {
                        map[i, j] = b2;
                    }
                    else if ((i == x1b && j == y1b) || (i == 12 && j == 12))
                    {
                        map[i, j] = b2;
                    }
                    else if (i == x3b && j == y3b)
                    {
                        map[i, j] = b3;
                    }
                    else if ((i == x1b && j == y1b) || (i == x2b && j == y2b) || (i == 12 && j == 12))
                    {
                        map[i, j] = b3;
                    }
                    else if (i == x4b && j == y4b)
                    {
                        map[i, j] = b4;
                    }
                    else if ((i == x1b && j == y1b) || (i == x2b && j == y2b) || (i == x3b && j == y3b) || (i == 12 && j == 12))
                    {
                        map[i, j] = b4;
                    }
                    else if (i == x5b && j == y5b)
                    {
                        map[i, j] = b5;
                    }
                    else if ((i == x1b && j == y1b) || (i == x2b && j == y2b) || (i == x3b && j == y3b) || (i == x4b && j == y4b) || (i == 12 && j == 12))
                    {
                        map[i, j] = b5;
                    }


                    else if ((i == x1 && j == y1))
                    {
                        map[i, j] = e1;
                    }
                    else if ((i == 12 && j == 12))
                    {
                        map[i, j] = e1;
                    }
                    else if (i == x2 && j == y2)
                    {
                        map[i, j] = e2;
                    }
                    else if ((i == x1 && j == y1) || (i == 12 && j == 12))
                    {
                        map[i, j] = e2;
                    }
                    else if (i == x3 && j == y3)
                    {
                        map[i, j] = e3;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == 12 && j == 12))
                    {
                        map[i, j] = e3;
                    }
                    else if (i == x4 && j == y4)
                    {
                        map[i, j] = e4;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == 12 && j == 12))
                    {
                        map[i, j] = e4;
                    }
                    else if (i == x5 && j == y5)
                    {
                        map[i, j] = e5;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == 12 && j == 12))
                    {
                        map[i, j] = e5;
                    }
                    else if (i == x6 && j == y6)
                    {
                        map[i, j] = e6;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == 12 && j == 12))
                    {
                        map[i, j] = e6;
                    }
                    else if (i == x7 && j == y7)
                    {
                        map[i, j] = e7;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == 12 && j == 12))
                    {
                        map[i, j] = e7;
                    }
                    else if (i == x8 && j == y8)
                    {
                        map[i, j] = e8;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == 12 && j == 12))
                    {
                        map[i, j] = e8;
                    }
                    else if (i == x9 && j == y9)
                    {
                        map[i, j] = e9;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == 12 && j == 12))
                    {
                        map[i, j] = e9;
                    }
                    else if (i == x10 && j == y10)
                    {
                        map[i, j] = e10;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == x9 && j == y9) || (i == 12 && j == 12))
                    {
                        map[i, j] = e10;
                    }
                    else if (i == x11 && j == y11)
                    {
                        map[i, j] = e11;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == x9 && j == y9) || (i == x10 && j == y10) || (i == 12 && j == 12))
                    {
                        map[i, j] = e11;
                    }
                    else
                    {
                        map[i, j] = '-';
                    }
                    map[k, l] = P;
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
            ConsoleKeyInfo direction = Console.ReadKey();

            switch (direction.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        l--;
                        steps++;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        l++;
                        steps++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    {
                        k--;
                        steps++;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    {
                        k++;
                        steps++;
                    }
                    break;
                default:
                    Console.WriteLine("Вы нажали не тот символ");
                    break;
            }

            if (map[k, l] == h1)
            {
                h1 = '0';
                HP = 31;
            }
            else if (P == h2)
            {
                h2 = '0';
                HP = 31;
            }
            else if (P == h3)
            {
                h3 = '0';
                HP = 31;
            }
            else if (P == h4)
            {
                h4 = '0';
                HP = 31;
            }
            else if (P == h5)
            {
                h5 = '0';
                HP = 31;
            }
            if (P == b1)
            {
                b1 = '0';
                power = 10;
                if ((power == 10) && ((P == b2) || (P == b3) || (P == b4) || (P == b5)))
                {
                    power = 10 * 2;
                }
            }
            if (P == b2)
            {
                b2 = '0';
                power = 10;
                if ((power == 10) && ((P == b1) || (P == b3) || (P == b4) || (P == b5)))
                {
                    power = 10 * 2;
                }
            }
            if (P == b3)
            {
                b2 = '0';
                power = 10;
                if ((power == 10) && ((P == b2) || (P == b1) || (P == b4) || (P == b5)))
                {
                    power = 10 * 2;
                }
            }
            if (P == b4)
            {
                b2 = '0';
                power = 10;
                if ((power == 10) && ((P == b2) || (P == b1) || (P == b3) || (P == b5)))
                {
                    power = 10 * 2;
                }
            }
            if (P == b5)
            {
                b2 = '0';
                power = 10;
                if ((power == 10) && ((P == b2) || (P == b1) || (P == b3) || (P == b4)))
                {
                    power = 10 * 2;
                }
            }

            if (map[k, l] == e1)
            {
                while (HP1 > 0)
                {
                    map[k, l] = e1;
                    HP1 = HP1 - power;
                    e1 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP1 <= 0)
            {
                e1 = '0';
            }
            else if (map[k, l] == e2)
            {
                while (HP2 > 0)
                {
                    map[k, l] = e2;
                    HP2 = HP2 - power;
                    e2 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP2 <= 0)
            {
                e2 = '0';
            }
            else if (map[k, l] == e3)
            {
                while (HP3 > 0)
                {
                    map[k, l] = e3;
                    HP3 = HP3 - power;
                    e3 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP3 <= 0)
            {
                e3 = '0';
            }
            else if (map[k, l] == e4)
            {
                while (HP4 > 0)
                {
                    map[k, l] = e4;
                    HP4 = HP4 - power;
                    e4 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP4 <= 0)
            {
                e4 = '0';
            }
            else if (map[k, l] == e5)
            {
                while (HP5 > 0)
                {
                    map[k, l] = e5;
                    HP5 = HP5 - power;
                    e5 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP5 <= 0)
            {
                e5 = '0';
            }
            else if (map[k, l] == e6)
            {
                while (HP6 > 0)
                {
                    map[k, l] = e6;
                    HP6 = HP6 - power;
                    e6 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP6 <= 0)
            {
                e6 = '0';
            }
            else if (map[k, l] == e7)
            {
                while (HP7 > 0)
                {
                    map[k, l] = e7;
                    HP7 = HP7 - power;
                    e7 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP7 <= 0)
            {
                e7 = '0';
            }
            else if (map[k, l] == e8)
            {
                while (HP8 > 0)
                {
                    map[k, l] = e8;
                    HP8 = HP8 - power;
                    e8 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP8 <= 0)
            {
                e8 = '0';
            }
            else if (map[k, l] == e9)
            {
                while (HP9 > 0)
                {
                    map[k, l] = e9;
                    HP9 = HP9 - power;
                    e9 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP9 <= 0)
            {
                e9 = '0';
            }
            else if (map[k, l] == e10)
            {
                while (HP10 > 0)
                {
                    map[k, l] = e10;
                    HP10 = HP10 - power;
                    e10 = map[k, l];
                    HP = HP - 5;
                }
            }
            else if (HP10 <= 0)
            {
                e10 = '0';
            }
            else if (map[k, l] == e11)
            {
                while (HP11 > 0)
                {
                    map[k, l] = e11;
                    HP11 = HP11 - power;
                    e11 = map[k, l];
                    HP = HP - 7;
                }
            }
            else if (HP11 <= 0)
            {
                e11 = '0';
            }
            //if ((power == 10) && (direction ==)
            //{
            //    r++;
            //    if (r == 5)
            //    {
            //        power = 5;
            //    }
            //}
            Console.WriteLine($"Player Health: {HP}");
            Console.WriteLine($"Player power: {power}");
        }
        public static void UpdateMap()//обновление карты после действий
        {
            char direction = Convert.ToChar(Console.ReadLine());
            char[,] map = new char[25, 25];
            char P = 'P';
            char h1 = 'H';
            char h2 = 'H';
            char h3 = 'H';
            char h4 = 'H';
            char h5 = 'H';
            char b1 = 'B';
            char b2 = 'B';
            char b3 = 'B';
            char b4 = 'B';
            char b5 = 'B';
            char e1 = 'E';
            char e2 = 'E';
            char e3 = 'E';
            char e4 = 'E';
            char e5 = 'E';
            char e6 = 'E';
            char e7 = 'E';
            char e8 = 'E';
            char e9 = 'E';
            char e10 = 'E';
            char e11 = 'S';
            int power = 5;
            int HP = 31;
            while (true)
            {
                GenerateMap(ref map, ref P, ref e1, ref e2, ref e3, ref e4, ref e5, ref e6, ref e7, ref e8, ref e9, ref e10, ref e11, ref h1, ref h2, ref h3, ref h4, ref h5, ref b1, ref b2, ref b3, ref b4, ref b5);
                Console.Clear();
            }
        }
        public static void Healing(ref char h1, ref char h2, ref char h3, ref char h4, ref char h5)// лечение
        {
            h1 = 'H';
            h2 = 'H';
            h3 = 'H';
            h4 = 'H';
            h5 = 'H';
        }
        public static void Buff(ref char b1, ref char b2, ref char b3, ref char b4, ref char b5)//увеличение силы
        {
            b1 = 'B';
            b2 = 'B';
            b3 = 'B';
            b4 = 'B';
            b5 = 'B';
        }
        public static void SaveState(char[,] map)//сохранение в файл
        {
            int HP = 31;
            int power = 5;
            using (FileStream fileStream = File.Open(@"F:\321.txt", FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write("Player Health = " + HP + "\n");
                    streamWriter.Write("Player Power = " + power + "\n");
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            streamWriter.Write(map[i, j] + " ");
                        }
                        streamWriter.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)//вызовы методов
        {
            Console.WriteLine("Menu");
            Console.WriteLine("PROD by Zalozniy & Shirokov");
            Console.WriteLine("Press any buttom to start ");
            char selection = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            char h1 = 'H';
            char h2 = 'H';
            char h3 = 'H';
            char h4 = 'H';
            char h5 = 'H';
            char b1 = 'B';
            char b2 = 'B';
            char b3 = 'B';
            char b4 = 'B';
            char b5 = 'B';
            char e1 = 'E';
            char e2 = 'E';
            char e3 = 'E';
            char e4 = 'E';
            char e5 = 'E';
            char e6 = 'E';
            char e7 = 'E';
            char e8 = 'E';
            char e9 = 'E';
            char e10 = 'E';
            char e11 = 'S';
            char[,] map = new char[25, 25];
            char P = 'P';
            int power = 5;
            int HP = 31;
            //GenerateMap(ref map, ref P, ref e1, ref e2, ref e3, ref e4, ref e5, ref e6, ref e7, ref e8, ref e9, ref e10, ref e11, ref h1, ref h2, ref h3, ref h4, ref h5, ref b1, ref b2, ref b3, ref b4, ref b5);
            UpdateMap();
            SaveState(map);
        }
    }
}