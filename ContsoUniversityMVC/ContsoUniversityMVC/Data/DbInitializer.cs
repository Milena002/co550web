using ContosoUniversityMVC.Models;
using ContsoUniversityMVC.Data;
using System;
using System.Diagnostics;
using System.Linq;

namespace ContosoUniversityMVC.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Maja",LastName="Michalska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstName="Dawid",LastName="Ciesla",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstName="Natalia",LastName="Marchlewska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstName="Leo",LastName="Tabby",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstName="Basia",LastName="Kolakowska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstName="Igor",LastName="Iwko",EnrollmentDate=DateTime.Parse("2022-09-01")},
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
