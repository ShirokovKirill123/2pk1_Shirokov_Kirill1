namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = "qwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбю ";

            char[] chars = txt.ToCharArray();
            string newtxt = string.Empty;
            bool isFind = false;

            while (true)
            {
                string str = Console.ReadLine();
                str.ToLower();

                for (int i = 0; i < chars.Length; i++)
                {
                    if (str.Contains(chars[i]))
                    {
                        if (!isFind)
                        {
                            newtxt = str;

                            if (newtxt != string.Empty)
                            {
                                isFind = true;
                            }
                        }

                    }
                }
                if (str == string.Empty)
                {
                    Console.WriteLine(newtxt);
                    break;
                }
            }
        }
    }
}