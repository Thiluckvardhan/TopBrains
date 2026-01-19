namespace CustomSorting
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    public class StudnetComparer : IComparer(Studnet)
    {
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Name = "Akhil", Age = 21, Marks = 95 },
                new Student { Name = "Bhanu", Age = 19, Marks = 95 },   
                new Student { Name = "Charan", Age = 20, Marks = 88 },
                new Student { Name = "Divya", Age = 18, Marks = 88 },   
                new Student { Name = "Esha", Age = 22, Marks = 99 },
                new Student { Name = "Farhan", Age = 17, Marks = 75 },
                new Student { Name = "Ganesh", Age = 19, Marks = 99 }, 
                new Student { Name = "Harsha", Age = 20, Marks = 60 }
            };
            List<Student>result=students.OrderByDescending(s=>s.Marks).ThenBy(s=>s.Age).ToList();

            foreach(Student item in result)
            {
                System.Console.WriteLine($"Name: {item.Name} Age: {item.Age}  Marks: {item.Marks}");
            }
        }
    }
}