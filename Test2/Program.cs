namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 0);
            char[,] map =
            {
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            {'#','$','#',' ',' ',' ',' ',' ','$',' ',' ','#','$',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','$',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#'},
            {'#',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$',' ','#'},
            {'#','$','#',' ','$',' ',' ','#',' ',' ','$',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
            };

            int userX = 10, userY = 5;
            char[] wallet = new char[1];

            while (true)
            {
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 12);
                Console.Write("Кшелёк:");

                for (int i = 0; i < wallet.Length; i++)
                {
                    Console.Write(wallet[i] + " ");
                }


                Console.SetCursorPosition(userX, userY);
                Console.Write('@');

                ConsoleKeyInfo moveKey = Console.ReadKey();

                switch (moveKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userY - 1, userX] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userY + 1, userX] != '#')
                        {
                            userY++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userY, userX - 1] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userY, userX + 1] != '#')
                        {
                            userX++;
                        }
                        break;

                }

                if (map[userY, userX] == '$')
                {
                    map[userY, userX] = 'o';

                    char[] tempWallet = new char[wallet.Length + 1];
                    for (int i = 0; i < wallet.Length; i++)
                    {
                        tempWallet[i] = wallet[i];
                    }
                    tempWallet[tempWallet.Length - 1] = '$';
                    wallet = tempWallet;
                }

                Console.Clear();
            }

        }
    }
}