namespace test
{
    internal class Program
    {
        public static void ParametrsOfPlayer(ref int power,ref int HP)
        {
            HP = 31;
            power = 5;
            Healing(power, ref HP);
            Buff(ref power, HP);
            int i = 0;
            char direction = '2';
            if (power == 10 && ((Move(ref direction) == 'w') || (Move(ref direction) == 'a') || (Move(ref direction) == 's') || (Move(ref direction) == 'd')))
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
        public static void GenerateMap(char[,] map,ref char e1, ref char e2, ref char e3, ref char e4, ref char e5, ref char e6, ref char e7, ref char e8, ref char e9, ref char e10, ref char e11)//генерация карты
        {
            map = new char[25, 25];
            char P = 'P';
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
                    if ((i == x1 && j == y1))
                    {
                        map[i, j] = e1;
                    }
                    else if (i == x2 && j == y2)
                    {
                        map[i, j] = e2;
                    }
                    else if (i == x1 && j == y1)
                    {
                        map[i, j] = e2;
                    }
                    else if (i == x3 && j == y3)
                    {
                        map[i, j] = e3;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2))
                    {
                        map[i, j] = e3;
                    }
                    else if (i == x4 && j == y4)
                    {
                        map[i, j] = e4;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3))
                    {
                        map[i, j] = e4;
                    }
                    else if (i == x5 && j == y5)
                    {
                        map[i, j] = e5;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4))
                    {
                        map[i, j] = e5;
                    }
                    else if (i == x6 && j == y6)
                    {
                        map[i, j] = e6;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5))
                    {
                        map[i, j] = e6;
                    }
                    else if (i == x7 && j == y7)
                    {
                        map[i, j] = e7;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6))
                    {
                        map[i, j] = e7;
                    }
                    else if (i == x8 && j == y8)
                    {
                        map[i, j] = e8;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7))
                    {
                        map[i, j] = e8;
                    }
                    else if (i == x9 && j == y9)
                    {
                        map[i, j] = e9;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8))
                    {
                        map[i, j] = e9;
                    }
                    else if (i == x10 && j == y10)
                    {
                        map[i, j] = e10;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == x9 && j == y9))
                    {
                        map[i, j] = e10;
                    }
                    else if (i == x11 && j == y11)
                    {
                        map[i, j] = e11;
                    }
                    else if ((i == x1 && j == y1) || (i == x2 && j == y2) || (i == x3 && j == y3) || (i == x4 && j == y4) || (i == x5 && j == y5) || (i == x6 && j == y6) || (i == x7 && j == y7) || (i == x8 && j == y8) || (i == x9 && j == y9) || (i == x10 && j == y10))
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
        public static char Move(ref char direction)//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
        {
            //Здесь нужно как-то реализовать ссылку на карту
            //int i = 0;
            //int j = 0;
            //switch (direction)
            //{
            // case 'w':
            // j++;
            // break;
            // case 's':
            // j--;
            // break;
            // case 'a':
            // i--;
            // break;
            // case 'd':
            // i++;
            // break;
            // default:
            // Console.WriteLine("Вы нажали не тот символ");
            // break;
            //}
            //Также здесь надо пропоисать то,чтобы игрок не смог выйти за пределы карты
            return direction;
        }
        public static void Fight(char [,] map,ref int HP, ref int power)//обмен ударами игрока и врага до полной потери здоровья одним из них
        {
            //Здесь нужно как-то реализовать ссылку на карту
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

            //if(координата P == координата e1)
            {
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
        public static void Healing(int power, ref int HP)// лечение
        {
            char h1 = 'H';
            char h2 = 'H';
            char h3 = 'H';
            char h4 = 'H';
            char h5 = 'H';
            //if(координата игрока = координата 1 аптечки)
            {
                h1 = '-';
                HP = 31;
            }
            //if(координата игрока = координата 2 аптечки)
            {
                h2 = '-';
                HP = 31;
            }
            //if(координата игрока = координата 3 аптечки)
            {
                h3 = '-';
                HP = 31;
            }
            //if(координата игрока = координата 4 аптечки)
            {
                h4 = '-';
                HP = 31;
            }
            //if(координата игрока = координата 5 аптечки)
            {
                h5 = '-';
                HP = 31;
            }
        }
        public static void Buff(ref int power, int
        HP)//увеличение силы
        {
            char b1 = 'B';
            char b2 = 'B';
            char b3 = 'B';
            char b4 = 'B';
            char b5 = 'B';
            //if(координата игрока = координата 1 баффа)
            {
                b1 = '-';
                power = 10;
                // if(power == 10 || //координата игрока = координата 2 баффа && координата игрока = координата 3 баффа && координата игрока = координата 4 баффа && координата игрока = координата 5 баффа)
                {
                    power = 10 * 2;
                }
            }
            //if(координата игрока = координата 2 баффа)
            {
                b2 = '-';
                power = 10;
                // if (power == 10 || //координата игрока = координата 1 баффа && координата игрока = координата 3 баффа && координата игрока = координата 4 баффа && координата игрока = координата 5 баффа)
                {
                    power = 10 * 2;
                }
            }
            //if(координата игрока = координата 3 баффа)
            {
                b3 = '-';
                power = 10;
                // if (power == 10 || //координата игрока = координата 1 баффа && координата игрока = координата 2 баффа && координата игрока = координата 4 баффа && координата игрока = координата 5 баффа)
                {
                    power = 10 * 2;
                }
            }
            //if(координата игрока = координата 4 баффа)
            {
                b4 = '-';
                power = 10;
                // if (power == 10 || //координата игрока = координата 2 баффа && координата игрока = координата 3 баффа && координата игрока = координата 5 баффа && координата игрока = координата 1 баффа)
                {
                    power = 10 * 2;
                }
            }
            //if(координата игрока = координата 5 баффа)
            {
                b5 = '-';
                power = 10;
                // if (power == 10 || //координата игрока = координата 2 баффа && координата игрока = координата 3 баффа && координата игрока = координата 4 баффа && координата игрока = координата 1 баффа)
                {
                    power = 10 * 2;
                }
            }
        }
        public static void SaveState(char[,] map)//сохранение в файл
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
            char selection = Convert.ToChar(Console.ReadLine());
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
            GenerateMap(map,ref e1, ref e2, ref e3, ref e4, ref e5, ref e6, ref e7, ref e8, ref e9, ref e10, ref e11);
        }
    }
}