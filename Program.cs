using System;
using System.Collections.Generic;
using StudentManagementSystem.Models;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        DatabaseHelper db = new DatabaseHelper();

        while (true)
        {
            Console.WriteLine("1- Add Student");
            Console.WriteLine("2- Show Students");
            Console.WriteLine("3- Exit");
            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                // هنا هتكتب الكود اللي يدخل بيانات الطالب
            }
            else if (choice == 2)
            {
                // هنا هتكتب الكود اللي يعرض كل الطلاب
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}