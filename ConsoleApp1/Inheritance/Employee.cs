using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Inheritance
{
    internal class Employee
    {
        public string name;
        public int id;
        public string gender;
        public bool isWorking;
        public Employee(): this("John", 0, "Male", false)
        {
            Console.WriteLine("Inside the default constructor of Employee");
        }

        public Employee(string name, int id, string gender, bool isWorking)
        {
            Console.WriteLine("Inside the parametarised constructor of Employee");
            this.name = name;
            this.id = id;
            this.gender = gender;
            this.isWorking = isWorking;
        }

        public void show()
        {
            Console.WriteLine($"Employee ID : {this.id}.");
            Console.WriteLine($"Employee Name : {this.name}.");
            Console.WriteLine($"Employee Gender : {this.gender}.");
            Console.WriteLine($"Employee Working : {this.isWorking}.");
        }
    }

    internal class Manager: Employee 
    {
        public Manager()
        {
            Console.WriteLine("Inside the default constructor of Manager");
        }
    }


    
}
