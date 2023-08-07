using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;

namespace BinarySerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter employee id: ");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee first name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter employee last name");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            employee.Salary = double.Parse(Console.ReadLine());
            

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream writer = new FileStream("D:\\Training\\C#\\Day 21\\Assignment_24\\BinarySerialization\\BinarySerialization\\employee.bin", FileMode.Create))
            {
                formatter.Serialize(writer, employee);
            }
            Console.WriteLine("Binary Serialization Complete");

            Console.ReadKey();
        }
    }
}
