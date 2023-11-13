using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Assihnment2
{
    public class Ourclass
    {
        public int Calc(string type, int whour, int nwdays, int projecthandles, int extras)
        {
            if (type == "HR")
            {
                projecthandles = 1;
                extras = 0;
                int n = whour * nwdays * 100 + projecthandles * 3000 + extras * 2000;
                return n;
            }
            else if (type == "Admin")
            {
                extras = 0;
                int n = whour * nwdays * 100 + projecthandles * 3000 + extras * 2000;
                return n;
            }
            else if (type == "Software Developer")
            {
                int n = whour * nwdays * 100 + projecthandles * 3000 + extras * 2000;
                return n;
            }
            else
            {
                Console.WriteLine("Invalid Employee Type");
            }
            //int n=whour*nwdays*100 + projecthandles * 3000 + extras * 2000;
            return 0;

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Ourclass obj = new Ourclass();
            Console.WriteLine("Enter Employee Type");
            string etype = Console.ReadLine();
            Console.WriteLine("Enter Employee Work Hours");
            int hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Employee's Working Days");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of projects handled by the Employee");
            int project = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee extras");
            int ext = int.Parse(Console.ReadLine());
            int res = obj.Calc(etype, hours, days, project, ext);
            Console.WriteLine("Monthly Salary of the Employee " + res);
            Console.ReadKey();
        }
    }
}