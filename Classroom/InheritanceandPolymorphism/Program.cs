using System;
using System.Collections.Generic;

namespace InheritanceandPolymorphism
{
    public abstract class Employee
    {
        public decimal pay { get; set; }
        public abstract decimal Pay();
    }

    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(decimal rate, decimal hours)
        {
            pay = Math.Round(rate * hours, 2);
        }

        public override decimal Pay() => pay;
    }

    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(decimal monthlySalary)
        {
            pay = Math.Round(monthlySalary, 2);
        }

        public override decimal Pay() => pay;
    }

    public class CommissionEmployee : Employee
    {
        public CommissionEmployee(decimal commission, decimal baseSalary)
        {
            pay = Math.Round(baseSalary + commission, 2);
        }

        public override decimal Pay() => pay;
    }

    public class Program
    {
        public static void Main()
        {
            string[] employees =
            {
                "H 100 5",
                "S 25000",
                "C 3000 20000",
                "H abc 5",
                "S 99999x"
            };

            List<Employee> list = new List<Employee>();

            foreach (string line in employees)
            {
                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 0) continue;

                if (parts[0] == "S" && parts.Length == 2)
                {
                    if (decimal.TryParse(parts[1], out decimal salary))
                        list.Add(new SalariedEmployee(salary));
                }
                else if (parts[0] == "H" && parts.Length == 3)
                {
                    if (decimal.TryParse(parts[1], out decimal rate) &&
                        decimal.TryParse(parts[2], out decimal hours))
                        list.Add(new HourlyEmployee(rate, hours));
                }
                else if (parts[0] == "C" && parts.Length == 3)
                {
                    if (decimal.TryParse(parts[1], out decimal commission) &&
                        decimal.TryParse(parts[2], out decimal baseSalary))
                        list.Add(new CommissionEmployee(commission, baseSalary));
                }
            }

            decimal totalPay = 0m;
            foreach (Employee e in list)
                totalPay += e.Pay();

            Console.WriteLine($"{totalPay:F2}");
        }
    }
}
