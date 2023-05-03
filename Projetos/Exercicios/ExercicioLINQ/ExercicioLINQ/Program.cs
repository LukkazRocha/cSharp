using ExercicioLINQ.Entities;
using System.Globalization;

namespace ExercicioLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double minSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine($"Email of people whose salary ir more than {minSalary.ToString("F2", CultureInfo.InvariantCulture)}:");
            var r1 = list.Where(p => p.Salary > minSalary).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string email in r1)
            {
                Console.WriteLine(email);
            }

            var r2 = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + r2.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}