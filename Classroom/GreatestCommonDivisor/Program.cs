namespace GreatestCommonDivisor
{
    public class GCDFinder
    {
        public int GCD(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return GCD(num2, num1 % num2);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------------------GCD Calculator of Two Numbers----------------------");

            Console.Write("Enter 1st Number: ");
            string inputcarrier = Console.ReadLine();
            if (!int.TryParse(inputcarrier.Trim(), out int num1))
            {
                Console.WriteLine("Please Enter only Integer as input");
                return;
            }

            Console.Write("Enter 2nd Number: ");
            inputcarrier = Console.ReadLine();
            if (!int.TryParse(inputcarrier.Trim(), out int num2))
            {
                Console.WriteLine("Please Enter only Integer as input");
                return;
            }

            if (num1 < 0 || num2 < 0)
            {
                Console.WriteLine("Numbers Cannot be Negative");
                return;
            }

            GCDFinder gcdFinder = new();
            int gcd = gcdFinder.GCD(num1, num2);

            Console.WriteLine($"GCD of Given Two Numbers is : {gcd}");
        }
    }
}
