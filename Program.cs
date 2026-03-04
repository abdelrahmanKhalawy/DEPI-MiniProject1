using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using StudentManagementSystem.Models;

class Program
{
    public static void PrintMenu()
    {
        List<Student> students = new List<Student>();
        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1- Add Student");
            Console.WriteLine("2- Show Students");
            Console.WriteLine("3- Delete a Student");
            Console.WriteLine("4- Exit");
            Console.Write("Choose:");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 1)
                {
                    AddStudent(students);
                    continue;
                }
                else if (choice == 2)
                {
                    ShowStudent(students);
                    continue;
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Delete student");
                    continue;
                }
                else if (choice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Application Stopped");
                    Console.ResetColor();
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid Input. Please try again.");
                    Console.ResetColor();
                    continue;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please try again.");
                Console.ResetColor();
            }
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
                    if (inputAge < 5)
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
                    if (grade < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("How can a grade be less than zero? Please try again.");
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("There are no students to show stats");
            Console.ResetColor();
            return;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Student list: ");
        foreach (Student s in studentslist)
        {
            s.PrintInfo();
        }
        Console.ResetColor();
    }
    public static void DeleteStudent(List<Student> studentslist)
    {

    }
    static void Main()
    {
        PrintMenu();
    }
}