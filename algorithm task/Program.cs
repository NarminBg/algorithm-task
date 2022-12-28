namespace algorithm_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] digits = new int[10];
            bool muxtelifreqemli = true;
            while (number > 0)
            {

                int digit = number % 10;
                if (digits[digit] == 1)
                {
                    muxtelifreqemli = false;
                    break;
                }
                digits[digit] = 1;
                number /= 10;

            }

            if (muxtelifreqemli == true)
            {
                Console.WriteLine("muxtelifreqemli");
            }
        }
    }
}