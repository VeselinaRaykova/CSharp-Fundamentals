using System;
using System.Collections.Generic;
using System.Linq;

namespace _08CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (data[0] != "End")
            {
                string companyName = data[0];
                string employeeID = data[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                data = Console.ReadLine().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            }

            foreach (var company in companies.OrderBy(c=>c.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
