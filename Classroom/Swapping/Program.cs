namespace Swapping
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new();
            Console.WriteLine("Enter Two Numbers to Swap using Reference:");
            System.Console.Write("Enter First Number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }
            System.Console.Write("Enter Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }
            System.Console.WriteLine("Using SwapWithRef Method:");
            Console.WriteLine($"Before Swapping values are {a} and {b}");
            p.SwapWithRef(ref a, ref b);
            Console.WriteLine($"After Swapping values are {a} and {b}");
            System.Console.WriteLine("Using SwapWithOut Method:");
            Console.WriteLine($"Before Swapping values are {a} and {b}");
            if (p.SwapWithOut(out a, out b))
            {
                Console.WriteLine($"After Swapping values are {a} and {b}");
            }

        }
        public void SwapWithRef(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public bool SwapWithOut(out int a, out int b)
        {
            Console.WriteLine("Enter Two Numbers to Swap using Out:");
            System.Console.Write("Enter First Number: ");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                b = 0;
                return false;
            }
            System.Console.Write("Enter Second Number: ");
            if (!int.TryParse(Console.ReadLine(), out b))// if fails sets b to 0 automatically
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return false;
            }
            Console.WriteLine($"Before Swapping values are {a} and {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            return true;
        }
    }
}