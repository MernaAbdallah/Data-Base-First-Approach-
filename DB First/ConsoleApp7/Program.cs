using Microsoft.EntityFrameworkCore;
using System;


namespace ConsoleApp7
{
    class program
    {

            public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
        }

        public class SchoolContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                //MERNA-ABDALLA\SQLEXPRESS
                optionsBuilder.UseSqlServer(@"Server=MERNA-ABDALLA\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True; TrustServerCertificate=True;");
            }
        }

         static void Main(string[] args)
        {

        }

    }
    
}

