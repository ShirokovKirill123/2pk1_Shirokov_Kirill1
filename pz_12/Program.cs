namespace pz_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int summa;
            int[] nums = { 123, 234, 456, 724, 879 };
            //int[] arr2 = new int[3] { 1, 2, 3 };
            //int[] arr3 = new int[3] { 2, 3, 4 };
            //int[] arr4 = new int[3] { 4, 5, 6 };
            //int[] arr5 = new int[3] { 7, 2, 4 };
            //int[] arr6 = new int[3] { 8, 7, 9 };
            //Console.WriteLine("Полученный массив:");
            //for (int i = 0; i < nums.Length; i++)
            //{               
            //    Console.Write(nums[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Полученная суммма цифр массива:");
            //GetSummOfArray(arr2, out summa);
            //Console.Write(summa + "\t");
            //GetSummOfArray(arr3, out summa);
            //Console.Write(summa + "\t");
            //GetSummOfArray(arr4, out summa);
            //Console.Write(summa + "\t");
            //GetSummOfArray(arr5, out summa);
            //Console.Write(summa + "\t");
            //GetSummOfArray(arr6, out summa);
            //Console.Write(summa + "\t");


            int[] res = GetSummOfArray(nums);
            foreach (int i in res) Console.Write(i + " ");
            Console.ReadLine();
        }
        static int[] GetSummOfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int r1 = arr[i] / 100; //1
                int r2 = (arr[i] - r1 * 100) / 10; //2
                int r3 = (arr[i] - r1 * 100 - r2 * 10) / 1; //3
                // temp += r / 

                arr[i] = r1 + r2 + r3;
            }
            return arr;
            //results = 0;
            //foreach (int i in arr)
            //{
            //    results += i;
            //}
            //return results;
        }
    }
}