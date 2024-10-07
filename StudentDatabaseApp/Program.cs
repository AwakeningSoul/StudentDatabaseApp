using System;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Ensure the database is created
                context.Database.EnsureCreated();

                // Create a new student
                var student = new Student { Name = "Charly Green", Age = 35 };

                // Add the student to the context
                context.Students.Add(student);
                context.SaveChanges();

                // Display the student information
                Console.WriteLine($"Student Added: {student.Name}, Age: {student.Age}");
            }
        }
    }
}

