using System.Globalization;

namespace MultiplicationTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a Number to Find its Multiplication table: ");
            if(!int.TryParse(Console.ReadLine(),out int number))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }
            System.Console.Write("Enter the upto Limit of the multiples: ");
            if(!int.TryParse(Console.ReadLine(),out int upto))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }
            List<int> Table=new();
            for(int i = 1; i <= upto; i++)
            {
                Table.Add(i*number);
            }

            //Multiplication Table

            foreach(int num in Table)
            {
                System.Console.Write($"{num} ");
            }
        }
    }
}