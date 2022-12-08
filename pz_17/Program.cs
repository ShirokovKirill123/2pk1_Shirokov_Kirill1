namespace pz_17
{
    internal class Program
    {
        public static void ParametrsOfPlayer(ref int power, ref int HP)
        {
            HP = 31;
            power = 5;
            char[,] map = new char[25, 25];
            char P = 'P';
            char h1 = 'H';
            char h2 = 'H';
            char h3 = 'H';
            char h4 = 'H';
            char h5 = 'H';
            Healing(ref HP, ref h1, ref h2, ref h3, ref h4, ref h5);
            //Buff(ref power, HP)
            int i = 0;
            char direction = '2';
            if (power == 10 && ((Move(ref P, map, ref direction) == 'w') || (Move(ref P, map, ref direction) == 'a') || (Move(ref P, map, ref direction) == 's') || (Move(ref P, map, ref direction) == 'd')))
            {
                i++;
                if (i == 5)
                {
                    power = 5;
                }
            }
            Console.WriteLine($"Player Health: {HP}");
            Console.WriteLine($"Player power: {power}");
        }
        public static void GenerateMap(char[,] map, ref char P, ref char e1, ref char e2, ref char e3, ref char e4, ref char e5, ref char e6, ref char e7, ref char e8, ref char e9, ref char e10, ref char e11, ref char h1, ref char h2, ref char h3, ref char h4, ref char h5, ref char b1, ref char b2, ref char b3, ref char b4, ref char b5)//генерация карты
        {
            map = new char[25, 25];
            P = 'P';
            int power = 5;
            int HP = 31;
            h1 = 'H';
            h2 = 'H';
            h3 = 'H';
            h4 = 'H';
            h5 = 'H';
            Healing(ref HP, ref h1, ref h2, ref h3, ref h4, ref h5);
            Buff(ref power, HP, ref b1, ref b2, ref b3, ref b4, ref b5);
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
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[12, 12] = P;
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
                        map[i,j] = e11;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == x9 && j == y9) || (i == x10 && j == y10) || (i == 12 && j == 12))
                    {
                        map[i, j] = e11;
                    }
                    else
                    {
                        map[i, j] = '-';
                    }
                    map[12, 12] = P;
                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void UpdateMap()//обновление карты после действий
        {
            //Все совершаемые в игре действия(в конце сделаем)
            Console.Clear();
        }
        public static char Move(ref char P, char[,] map, ref char direction)//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
        {
            int HP = 31;
            int power = 5;
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
            Healing(ref HP, ref h1, ref h2, ref h3, ref h4, ref h5);
            Buff(ref power, HP, ref b1, ref b2, ref b3, ref b4, ref b5);
            int steps = 0;
            map = new char[25, 25];
            P = 'P';
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    while (true)
                    {
                        switch (direction)
                        {
                            case 'w':
                                j++;
                                steps++;
                                break;
                            case 's':
                                j--;
                                steps++;
                                break;
                            case 'a':
                                i--;
                                steps++;
                                break;
                            case 'd':
                                i++;
                                steps++;
                                break;
                            default:
                                Console.WriteLine("Вы нажали не тот символ");
                                break;
                                if (P == h1)
                                {
                                    h1 = '-';
                                    HP = 31;
                                }
                                else if (P == h2)
                                {
                                    h2 = '-';
                                    HP = 31;
                                }
                                else if (P == h3)
                                {
                                    h3 = '-';
                                    HP = 31;
                                }
                                else if (P == h4)
                                {
                                    h4 = '-';
                                    HP = 31;
                                }
                                else if (P == h5)
                                {
                                    h5 = '-';
                                    HP = 31;
                                }
                                if (P == b1)
                                {
                                    b1 = '-';
                                    power = 10;
                                    if ((power == 10) && ((P == b2) || (P == b3) || (P == b4) || (P == b5)))
                                    {
                                        power = 10 * 2;
                                    }
                                }
                                if (P == b2)
                                {
                                    b2 = '-';
                                    power = 10;
                                    if ((power == 10) && ((P == b1) || (P == b3) || (P == b4) || (P == b5)))
                                    {
                                        power = 10 * 2;
                                    }
                                }
                                if (P == b3)
                                {
                                    b2 = '-';
                                    power = 10;
                                    if ((power == 10) && ((P == b2) || (P == b1) || (P == b4) || (P == b5)))
                                    {
                                        power = 10 * 2;
                                    }
                                }
                                if (P == b4)
                                {
                                    b2 = '-';
                                    power = 10;
                                    if ((power == 10) && ((P == b2) || (P == b1) || (P == b3) || (P == b5)))
                                    {
                                        power = 10 * 2;
                                    }
                                }
                                if (P == b5)
                                {
                                    b2 = '-';
                                    power = 10;
                                    if ((power == 10) && ((P == b2) || (P == b1) || (P == b3) || (P == b4)))
                                    {
                                        power = 10 * 2;
                                    }
                                }
                        }
                        // Также здесь надо пропоисать то, чтобы игрок не смог выйти за пределы карты
                    }
                }
            }
            return direction;
        }
        public static void Fight(char[,] map,ref char P, ref int HP, ref int power)//обмен ударами игрока и врага до полной потери здоровья одним из них
        {
           // GenerateMap(char[,] map, ref char P, ref char e1, ref char e2, ref char e3, ref char e4, ref char e5, ref char e6, ref char e7, ref char e8, ref char e9, ref char e10, ref char e11, ref char h1, ref char h2, ref char h3, ref char h4, ref char h5, ref char b1, ref char b2, ref char b3, ref char b4, ref char b5)
            map = new char[25, 25];
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
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    //if(P == )
                    {
                        P = map[12, 12];
                        while (HP1 > 0)
                        {
                            //координата P = координата e1
                            HP1 = HP1 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e2)
                    {
                        while (HP2 > 0)
                        {
                            //координата P = координата e1
                            HP2 = HP2 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e3)
                    {
                        while (HP3 > 0)
                        {
                            //координата P = координата e1
                            HP3 = HP3 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e4)
                    {
                        while (HP4 > 0)
                        {
                            //координата P = координата e1
                            HP4 = HP4 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e5)
                    {
                        while (HP5 > 0)
                        {
                            //координата P = координата e1
                            HP5 = HP5 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e6)
                    {
                        while (HP6 > 0)
                        {
                            //координата P = координата e1
                            HP6 = HP6 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e7)
                    {
                        while (HP7 > 0)
                        {
                            //координата P = координата e1
                            HP7 = HP7 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e8)
                    {
                        while (HP8 > 0)
                        {
                            //координата P = координата e1
                            HP8 = HP8 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e9)
                    {
                        while (HP9 > 0)
                        {
                            //координата P = координата e1
                            HP9 = HP9 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                    }
                    //if(координата P == координата e10)
                    {
                        while (HP10 > 0)
                        {
                            //координата P = координата e1
                            HP10 = HP10 - power;
                            //координата e1 = координата P
                            HP = HP - 5;
                        }
                        while (HP11 > 0)
                        {
                            //координата P = координата e1
                            HP11 = HP11 - power;
                            //координата e1 = координата P
                            HP = HP - 7;
                        }
                    }
                }
            }
        }
        public static void Healing(ref int HP, ref char h1, ref char h2, ref char h3, ref char h4, ref char h5)// лечение
        {
            HP = 31;
            h1 = 'H';
            h2 = 'H';
            h3 = 'H';
            h4 = 'H';
            h5 = 'H';
        }
        public static void Buff(ref int power, int HP, ref char b1, ref char b2, ref char b3, ref char b4, ref char b5)//увеличение силы
        {
            b1 = 'B';
            b2 = 'B';
            b3 = 'B';
            b4 = 'B';
            b5 = 'B';
        }
        public static void
        SaveState(char[,] map)//сохранение в файл
        {
            int HP = 0;
            int power = 0;
            ParametrsOfPlayer(ref power, ref HP);
            using (FileStream fileStream = File.Open(@"C:Users\что-то\321.txt", FileMode.Create))
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
                        streamWriter.WriteLine();
                    }
                }
            }
        }
        static void Main(string[] args)//основные вызовы методов
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
            char e11 = 'E';
            char[,] map = new char[25, 25];
            char P = 'P';
            int power = 5;
            int HP = 30;
            ParametrsOfPlayer(ref power, ref HP); GenerateMap(map, ref P, ref e1, ref e2, ref e3, ref e4, ref e5, ref e6, ref e7, ref e8, ref e9, ref e10, ref e11, ref h1, ref h2, ref h3, ref h4, ref h5, ref b1, ref b2, ref b3, ref b4, ref b5);
        }
    }
}