namespace Programming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Give Input Range:");
            if(!(int.TryParse(Console.ReadLine(),out int start) && int.TryParse(Console.ReadLine(),out int end))){
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }

            int total = 0;
            int numberSum=0;
            int numberSquareSum=0;
            int temp=0;
            for (int number = start; number <= end; number++)
            {
                numberSum=0;
                numberSquareSum=0;
                if (! IsPrime(number))
                {
                    temp=number;
                    while (temp > 0)
                    {
                        numberSum+=temp%10;
                        temp=temp/10;
                    }

                    temp=number*number;
                    while (temp > 0)
                    {
                        numberSquareSum+=temp%10;
                        temp=temp/10;
                    }
                    if (numberSum * numberSum == numberSquareSum)
                    {
                        total++;
                    }
                }
            }
            System.Console.WriteLine($"Total Number of Lucky Number between {start} and {end} is/are : {total}");
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}