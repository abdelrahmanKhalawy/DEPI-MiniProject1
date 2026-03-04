using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using StudentManagementSystem.Models;

class Program
{
    public static void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n-----------------------------------");
        Console.WriteLine("ERROR: " + message);
        Console.WriteLine("-----------------------------------");
        Console.ResetColor();
    }

    public static void PrintMenu()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================");
            Console.WriteLine("        STUDENT MANAGEMENT SYSTEM      ");
            Console.WriteLine("=======================================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("1) Add Student");
            Console.WriteLine("2) Show Students");
            Console.WriteLine("3) Delete Student");
            Console.WriteLine("4) Exit");
            Console.WriteLine();
            Console.Write("Select an option (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        AddStudent(students);
                        break;

                    case 2:
                        ShowStudent(students);
                        break;

                    case 3:
                        DeleteStudent(students);
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nApplication Stopped.");
                        Console.ResetColor();
                        return;

                    default:
                        ShowError("Invalid choice. Please select from 1 to 4.");
                        break;
                }
            }
            else
            {
                ShowError("Invalid input. Please enter a number.");
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
    public static void AddStudent(List<Student> studentslist)
    {
        Console.Write("please enter the name of the student:");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
        {
            int inputAge;
            while (true)
            {
                Console.Write("Please enter his age:");
                if (int.TryParse(Console.ReadLine(), out inputAge))
                {
                    if (inputAge <= 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Age must be higher than 5 years old. Please try again.");
                        Console.ResetColor();
                        continue;
                    }
                    else
                        break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid age input. Please try again");
                    Console.ResetColor();
                    continue;
                }
            }
            double grade;
            while (true)
            {
                Console.Write("Please enter his grade:");
                if (double.TryParse(Console.ReadLine(), out grade))
                {
                    if (grade < 0 || grade > 100)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Grade Can Be between 0 and 100! Please try again.");
                        Console.ResetColor();
                        continue;
                    }
                    else
                        break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid grade input. Please try again");
                    Console.ResetColor();
                    continue;
                }
            }
            Student student = new Student(name, inputAge, grade);
            studentslist.Add(student);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student added successfully");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid name input. Please try again.");
            Console.ResetColor();
        }
    }
    public static void ShowStudent(List<Student> studentslist)
    {
        if (studentslist.Count == 0)
        {
            ShowError("There are no students to display.");
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("=========== STUDENT LIST ===========\n");
        Console.ResetColor();

        foreach (Student s in studentslist)
        {
            s.PrintInfo();
            Console.WriteLine("-----------------------------------");
        }
    }

    public static void DeleteStudent(List<Student> studentslist)
    {
        if (studentslist.Count() == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No students are available to delete");
            Console.ResetColor();
            return;
        }
        string? name;
        while (true)
        {
            Console.Write("Please enter the name of the student:");
            name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                var studenttodelete = studentslist.Where(n => n.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (studenttodelete != null)
                {
                    studentslist.Remove(studenttodelete);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("student deleted succesfully");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name not found. Please try again.");
                    Console.ResetColor();
                    continue;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input");
                Console.ResetColor();
                continue;
            }
        }
    }
    static void Main(string[] args)
    {
        PrintMenu();
    }
}