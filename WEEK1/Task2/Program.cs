using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{class Student
    {
        public string name;
        public string id;
        public int yearofstudy;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
            PrintInfo();
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name of student: ");
            Console.WriteLine("Id of student: ");
        }
        public int Nextyear(int y)
        {
            yearofstudy = y;
            return yearofstudy + 1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Write id: ");
            string id = Console.ReadLine();
            Console.WriteLine("Write year of study: ");
            string num = Console.ReadLine();
            int yearofstudy = int.Parse(num);
            Student student = new Student( name,  id);
            Console.WriteLine("Next year of study: "+ student.Nextyear(yearofstudy);
                
                

        }
    }
}