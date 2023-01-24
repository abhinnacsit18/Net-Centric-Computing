using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIC
{
    
    public static class ArrayTask
    {
        public struct Student
        {
            private int studentID;
            private string studentName;
            private string courseName;
            private DateOnly studentDateOfBirth;

            public Student(int id, string name, string course, DateOnly dob)
            {
                studentID = id;
                studentName = name;
                courseName = course;
                studentDateOfBirth = dob;
            }

            public void display()
            {
                Console.WriteLine($"\n-------\nStudent id is: {studentID}");
                Console.WriteLine($"Student name is: {studentName}");
                Console.WriteLine($"Couurse name is: {courseName}");
                Console.WriteLine($"Student date of birth is: {studentDateOfBirth}");
            }
        };
        static void Main()
        {
            int id, num, i;
            string name, course;
            DateOnly dob;

            Console.WriteLine("abhinna question 2\n");

            Console.WriteLine("\nEnter the number of students you want to add records of: ");
            num = int.Parse(Console.ReadLine());

            Student[] student = new Student[num];
            
            for (i = 0; i < num; i++)
            {
                Console.WriteLine($"\n#########\nEnter the student #{i + 1}'s id: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nEnter the student #{i + 1}'s name: ");
                name = (Console.ReadLine());
                Console.WriteLine($"\nEnter the student #{i + 1}'s course name: ");
                course = (Console.ReadLine());
                Console.WriteLine($"\nEnter the student #{i + 1}'s date of birth: ");
                dob = DateOnly.Parse((Console.ReadLine()));

                student[i] = new Student(id, name, course, dob);
            }

            Console.WriteLine($"\n\n#######\nDisplaying student #{i + 1}:");
            for (i = 0; i < num; i++)
            {
                student[i].display();
            }
        }
    }
}