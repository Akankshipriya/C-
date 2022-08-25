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
            string abc;

            do
            {
                Console.WriteLine("Press 1 to enter student data ");
                Console.WriteLine("Press 2 to display the data");
                int input = int.Parse(Console.ReadLine());
                int studentID = 0;
                string studentName = "";
                string studentCourse = "";
                int studentMarks = 0;
                int num, rem, temp, sum = 0;

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
                else if (input == 2)
                {
                    Console.WriteLine("ID : " + studentID);
                    Console.WriteLine("Name :" + studentName);
                    Console.WriteLine("Course :" + studentCourse);
                    Console.WriteLine("Marks :" + studentMarks);

                }
                else if (input == 3)
                {
                    Console.Write("Enter the Number to check palindrome: ");
                    num = int.Parse(Console.ReadLine());
                    temp = num;
                    while (num > 0)
                    {
                        rem = num % 10;
                        sum = (sum * 10) + rem;
                        num = num / 10;
                    }
                    if (temp == sum)
                    {
                        Console.Write("given num is Palindrome.");
                    }
                    else
                    {
                        Console.Write("given num is not Palindrome");
                    }
                }
                else
                {
                    Console.Write("Enter Your Number To Check Armstrong");
                    num = int.Parse(Console.ReadLine());
                    temp = num;
                    while (num > 0)
                    {
                        rem = num % 10;
                        sum = sum + (rem * rem * rem);
                        num = num / 10;
                    }

                    if (temp == sum)
                    {
                        Console.WriteLine("the given num is a Armstrong Number");
                    }
                    else
                    {
                        Console.WriteLine("the given num is not a Armstrong Number");
                    }
                }
                Console.WriteLine("Do you want to continue");
                abc = Console.ReadLine();
            } while (abc == "yes");
        }
    }
}
