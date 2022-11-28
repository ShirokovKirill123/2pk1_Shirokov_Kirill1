namespace pz_17
{
    internal class Program
    {        
            int HP = 30;
            int power = 5;
            int HP2 = 15;
            int power2 = 5;
            public static GenerateMap()//генерация карты
            {
                int[,] map = new int[25, 25];
                int P = 313;
                Random rnd = new Random();
                int e1 = 0;
                int e2 = 0;
                int e3 = 0;
                int e4 = 0;
                int e5 = 0;
                int e6 = 0;
                int e7 = 0;
                int e8 = 0;
                int e9 = 0;
                int e10 = 0;
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {                        
                        map[i, j] = map[i, j];
                        if (map[i, j] = )
                        {
                            P = map.GetLength;
                            e1 = rnd.Next(i, j);
                            e2 = rnd.Next(i, j);
                            e3 = rnd.Next(i, j);
                            e4 = rnd.Next(i, j);
                            e5 = rnd.Next(i, j);
                            e6 = rnd.Next(i, j);
                            e7 = rnd.Next(i, j);
                            e8 = rnd.Next(i, j);
                            e9 = rnd.Next(i, j);
                            e10 = rnd.Next(i, j);
                        }
                        Console.WriteLine(map[i, j]);
                        Console.WriteLine(P);
                    }
                    Console.WriteLine();
                }
            }
            public static UpdateMap()//обновление карты после действий
            {

            }
            public static Move(char direction)//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
            {
            switch(direction)
            {
                case 'w':

                break;
                case 's':

                break;
                case 'a':

                break;
                case 'd':

                break;
            }

            }
            public static Fight()//обмен ударами игрока и врага до полной потери здоровья одним из них
            {

            }
            public static Healing()// лечение
            {

            }
            public static Buff()//увеличение силы
            {

            }
            public static SaveState()//сохранение в файл
            {

            }
            static void Main(string[] args)//основные вызовы методов
            {

            }       
    }
}