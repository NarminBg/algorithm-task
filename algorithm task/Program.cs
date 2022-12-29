namespace algorithm_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded:");
            int number = Convert.ToInt32(Console.ReadLine());
            int r1, r2;
            int tmp;
            bool isDifferenceDigit = true;
            while (number > 0)
            {

                r1 = number % 10;
                number /= 10;
                tmp = number;
                while (tmp != 0)
                {
                    r2 = tmp % 10;
                    tmp /= 10;

                    if (r1 == r2)
                    {
                        Console.WriteLine("Muxtelifreqemli deyil");
                        isDifferenceDigit = false;
                        break;
                    }

                }
                if (!isDifferenceDigit)
                    break;
            }
            Console.WriteLine("Muxtelif reqemlidir");
        }
    }
    
   
    }
