namespace DictionaryLookup
{
    public class Program
    {
        public static void Main()
        {
            List<int> EmployeeIds = new List<int>()
            {
              1,4,5
            };
            Dictionary<int, int> EmployeeRecords = new Dictionary<int, int>()
            {
                {1,20000},
                {4,40000},
                {5,15000}
            };
            int totalSalary = 0;
            foreach (int employee in EmployeeIds)
            {
                if (EmployeeRecords.TryGetValue(employee, out int salary))
                {
                    totalSalary += salary;
                }
            }
            System.Console.WriteLine($"The Total Salary of the Employee Present int the List: {totalSalary}");
        }
    }
}