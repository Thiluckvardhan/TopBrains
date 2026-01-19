namespace MathRounding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------Area of Circle-----------------");
            Console.Write("Enter radius of the circle: ");
            if(!double.TryParse(Console.ReadLine(),out double radius))
            {
                System.Console.WriteLine("Please enter only numbers as input");
                return;
            }
            if(radius<0){
                System.Console.WriteLine("Radius can't be Negative");
                return;
            }
            Console.WriteLine($"Area of the Circle: {Math.Round(radius*radius*Math.PI,2,MidpointRounding.AwayFromZero):F2}");
        }
    }
}