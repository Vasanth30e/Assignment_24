using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using EmployeeLib;

namespace XMLSerialization
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

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using(TextWriter writer = new StreamWriter("D:\\Training\\C#\\Day 21\\Assignment_24\\XMLSerialization\\XMLSerialization\\employee.xml"))
            {
                serializer.Serialize(writer, employee);
            }

            Console.WriteLine("XML Serialization Complete");

            Console.ReadKey();
        }
    }
}
