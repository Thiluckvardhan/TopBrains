using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    public static class Extension
    {
        public static string[] DistinctBy(this string[] items)
        {
            List<string> result = new();
            HashSet<int> seen = new();

            foreach (string item in items)
            {
                string[] parts = item.Split(':');
                if (parts.Length != 2) continue;

                if (int.TryParse(parts[0].Trim(), out int id))
                {
                    if (seen.Add(id))
                        result.Add(parts[1].Trim());
                }
            }

            return result.ToArray();
        }
    }

    public class Program
    {
        public static void Main()
        {
            string[] items =
            {
                "101:Thiluck",
                "102:Divyansh",
                "101:Rahul",
                "103:Kiran",
                "104:Anjali",
                "102:Vishal",
                "105:Sneha",
                "103:Arjun"
            };

            string[] result = items.DistinctBy();

            foreach (string name in result)
            {
                Console.Write(name + " ");
            }
        }
    }
}
