namespace CountCharacterfromString
{
    public class Program
    {
        public static void Main(string[] args)
        {

            System.Console.WriteLine("-----------------String Counter-------------------");
            System.Console.WriteLine("Enter an Input to check the Count of its characters");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Your Input is Empty");
                return;
            }
            SortedDictionary<char, int> stringcounter = new();
            foreach (char letter in input)
            {
                stringcounter[letter] = stringcounter.ContainsKey(letter) ? stringcounter[letter] + 1 : 1;
            }

            System.Console.WriteLine("Character Count of your Input: ");
            foreach (var item in stringcounter)
            {
                System.Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}