using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Temp\temp.txt";

            /* Serialization
            Employee emp = new Employee(1, "Lokendra");
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, emp);
            stream.Close();
            Console.WriteLine("File saved in " + filePath);
            Console.ReadLine();
            */

            // Deserialization
            FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Employee emp = (Employee)formatter.Deserialize(stream);
            Console.WriteLine("Employee Id: " + emp.EmployeeId);
            Console.WriteLine("Employee Name " + emp.EmployeeName);
            Console.ReadLine();

        }
    }
}
