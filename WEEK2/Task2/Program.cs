using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2



{
    class Program
    {
        public static bool inPrime(int b)
        {
            if ((b == 1) || (b == 0))
                return false;

            for (int i = 2; i < b; i++)

            {
                if (b % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"C:\WEEK2\TASK2\reader.txt");
            StreamWriter writer = new StreamWriter(@"C:\WEEK2\TASK2\writer.txt");
            string n = reader.ReadLine();
            string[] ss = n.Split(' ');
            foreach (string s in ss)
            {
                if (inPrime(int.Parse(s)))
                    writer.Write(s + " ");
            }
            reader.Close();
            writer.Close();
        }
    }
}