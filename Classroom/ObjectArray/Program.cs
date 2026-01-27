namespace ObjectArray
{
    public class Program
    {
        public static void Main()
        {
            //Hardcoded Input
            object[] values = { 10, "hello", true, null, 20, 5, 1, 2, 3, 4, 5, "10", false, "abc", 12.5, -10, "x", -5, 100, 1000, "1000", 2000, 3000, 4000 };

            System.Console.WriteLine("-------------Object Array---------------");
            System.Console.WriteLine("Printing all the integers from the object array");
            int sum=0;
            foreach(object value in values)
            {
                if(value is int x)
                {
                    sum+=x;
                }
            }
            System.Console.WriteLine($"The total Sum of Integers in the Object Array is: {sum}");
        }
    }
}