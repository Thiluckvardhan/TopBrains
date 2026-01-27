namespace NullValue
{
    public class Program
    {
        List<double?> input = new();
        public double? CalculateAverage(List<double?> doubles)
        {
            double total = 0.0;
            int size = doubles.Count;

            foreach (double? item in doubles)
            {
                if (item == null)
                    size--;
                else
                    total += item.Value;
            }

            if (size == 0)
                return null;

            return Math.Round(total / size, 2, MidpointRounding.AwayFromZero);
        }

        public static void Main()
        {
            Program p = new();
            Console.WriteLine("-------------NULL VALUE------------");
            string? s = "";
            double? value;
            while (true)
            {
                Console.WriteLine("Enter q or Q to Quit");
                s = Console.ReadLine();
                if (s == "q" || s == "Q")
                {
                    break;
                }

                if (double.TryParse(s, out double temp))
                {
                    value = temp;
                    p.input.Add(value);
                }
            }
            double? avg = p.CalculateAverage(p.input);
            if (avg == null) System.Console.WriteLine("No Non-Null Values or No double values");
            else System.Console.WriteLine($"Avgerage of Non-Null values is: {avg}");
        }
    }
}