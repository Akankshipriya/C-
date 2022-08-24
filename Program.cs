using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to continue");
            string abc = Console.ReadLine();

            do
            {
                Console.WriteLine("Press 1 to enter student data ");
                Console.WriteLine("Press 2 to display the data");
                int input = int.Parse(Console.ReadLine());
                int studentID;
                string studentName;
                string studentCourse;
                int studentMarks;

                if (input == 1)
                {
                    Console.WriteLine("Enter student ID ");
                    studentID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student Name ");
                    studentName = Console.ReadLine();
                    Console.WriteLine("Enter student Course ");
                    studentCourse = Console.ReadLine();
                    Console.WriteLine("Enter student Marks ");
                    studentMarks = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("ID :", studentID);
                    Console.WriteLine("ID :", studentName);
                    Console.WriteLine("ID :", studentCourse);
                    Console.WriteLine("ID :", studentMarks);

                }
            } while (abc == "yes");
        }
    }
}
