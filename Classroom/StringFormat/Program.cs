using System.Text.Json;
namespace StringFormat
{
    public class Student
    {
        public string? Name { get; set; }
        public int Score { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new();
            string[] items =
            {
            "Thiluck:80",
            "Divyansh:79",
            "Aarjav:39",
            "Sumanth:80",
            "Harsha:45",
            };
            System.Console.WriteLine("Enter Minimum Score");
            if (!int.TryParse(Console.ReadLine(), out int MinScore))
            {
                System.Console.WriteLine("Please Enter only Integer as Input");
                return;
            }
            int temp;
            foreach (var item in items)
            {
                Student stu = new();
                var student = item.Split(':');
                if (student.Length != 2)
                {
                    Console.WriteLine("Input is Wrong");
                    return;
                }
                else if (!int.TryParse(student[1], out temp))
                {
                    Console.WriteLine("Score is not integer skipping this student");
                    continue;
                }
                stu.Name = student[0];
                stu.Score = temp;
                students.Add(stu);
            }
            var output = students.Where(s => s.Score >= MinScore).OrderByDescending(s => s.Score).ThenBy(s => s.Name).ToList();
            var jsonformat = JsonSerializer.Serialize(output, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            System.Console.WriteLine($"Students with {MinScore} as Minimum Score are :");
            Console.WriteLine(jsonformat);
        }
    }
}
