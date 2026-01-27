using System;
namespace Parsing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("----------------Parsing-----------------");
            
            List<string> tokens=new List<string>
            {"10", "20", "30", "5",
             "abc", "12", "x",
             "2147483647", "1",
              "-2147483648",
              "999999999999"
            };

            int sum=0;
            int result=0;
            foreach(string token in tokens)
            {
                if(Int32.TryParse(token,out result))
                {
                    sum+=result;
                }
            }
            System.Console.WriteLine($"Sum of the Numbers : {sum}");
        }

    }
}