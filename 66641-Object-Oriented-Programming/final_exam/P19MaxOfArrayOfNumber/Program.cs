namespace P19MaxOfArrayOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 7, 7, 6, 4, 0, 2, 2, 7, 1, 90 };
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max: " + max);
            Console.ReadKey();
        }
    }

}
