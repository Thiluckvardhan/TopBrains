namespace Conversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("---------------Conversion----------------");
            System.Console.Write("Enter Feet/Foot to Convert to Centimeters:");
            if(!int.TryParse(Console.ReadLine(),out int feet))
            {
                System.Console.WriteLine("Please Enter only Integer as input");
                return;
            }
            double centi=feet*30.48;
            System.Console.WriteLine($"{feet} in centimeters {Math.Round(centi,2,MidpointRounding.AwayFromZero)}cm");
        }
    }
}