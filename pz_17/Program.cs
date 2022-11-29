namespace pz_17
{
    internal class Program
    {        
            int HP = 30;
            int power = 5;           
            public static void GenerateMap()//генерация карты
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
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {                        
                        if (true)
                        {
                            P = map. ;
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
                    }
                    Console.WriteLine();
                }
            }
            public static void UpdateMap()//обновление карты после действий
            {
            //Все совершаемые в игре действия
            Console.Clear();
            }
            public static char Move(char direction)//реализация перемещения на нужную ячейку в связи с выбранным направлением direction, подсчет шагов
            {
            int x = 0;
            int y = 0;
            switch (direction)
            {
                case 'w':
                y++;
                break;
                case 's':
                y--;
                break;
                case 'a':
                x--;
                break;
                case 'd':
                x++;
                break;
                default:
                Console.WriteLine("Вы нажали не тот символ");
                break;
            }
            return direction;
            }
            public static void Fight()//обмен ударами игрока и врага до полной потери здоровья одним из них
            {

            }
            public static void Healing()// лечение
            {

            }
            public static void Buff()//увеличение силы
            {

            }
            public static void SaveState()//сохранение в файл
            {

            }
            static void Main(string[] args)//основные вызовы методов
            {
            char selection = Convert.ToChar(Console.ReadLine());
            GenerateMap();UpdateMap(); Move(selection); Fight(); Healing(); Buff(); SaveState();
            }       
    }
}