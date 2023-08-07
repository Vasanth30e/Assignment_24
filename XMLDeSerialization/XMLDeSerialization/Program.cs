using EmployeeLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLDeSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextReader reader = new StreamReader("D:\\Training\\C#\\Day 21\\Assignment_24\\XMLSerialization\\XMLSerialization\\employee.xml"))
            {
                Employee desEmployee = (Employee)serializer.Deserialize(reader);

                Console.WriteLine("XML Deserialization");
                Console.WriteLine("Employee ID: "+desEmployee.Id);
                Console.WriteLine("Employee First Name: " + desEmployee.FirstName);
                Console.WriteLine("Employee Last Name: " + desEmployee.LastName);
                Console.WriteLine("Employee Salary: " + desEmployee.Salary);
            }

            Console.WriteLine("\nXML Deserialization Complete");
            Console.ReadKey();
        }
    }
}
