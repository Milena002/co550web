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
                new Student{StudentID=1,FirstName="Maja",LastName="Michalska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{StudentID=2,FirstName="Dawid",LastName="Ciesla",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{StudentID=3,FirstName="Natalia",LastName="Marchlewska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{StudentID=4,FirstName="Leo",LastName="Tabby",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{StudentID=5,FirstName="Basia",LastName="Kolakowska",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{StudentID=6,FirstName="Igor",LastName="Iwko",EnrollmentDate=DateTime.Parse("2022-09-01")},
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=550,Title="Web Applications",Credits=4},
                new Course{CourseID=556,Title="Network Systems",Credits=4},
                new Course{CourseID=567,Title="Object Oriended SD",Credits=4},
                new Course{CourseID=558,Title="Database Design",Credits=4},
               
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=550,Grade=Grades.A},
                new Enrollment{StudentID=1,CourseID=556,Grade=Grades.C},
                new Enrollment{StudentID=1,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=1,CourseID=558,Grade=Grades.B},

                new Enrollment{StudentID=2,CourseID=550,Grade=Grades.A},
                new Enrollment{StudentID=2,CourseID=556,Grade=Grades.A},
                new Enrollment{StudentID=2,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=2,CourseID=558,Grade=Grades.C},

                new Enrollment{StudentID=3,CourseID=550,Grade=Grades.B},
                new Enrollment{StudentID=3,CourseID=556,Grade=Grades.C},
                new Enrollment{StudentID=3,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=3,CourseID=558,Grade=Grades.A},

                new Enrollment{StudentID=4,CourseID=550,Grade=Grades.A},
                new Enrollment{StudentID=4,CourseID=556,Grade=Grades.A},
                new Enrollment{StudentID=4,CourseID=567,Grade=Grades.A},
                new Enrollment{StudentID=4,CourseID=558,Grade=Grades.B},

                new Enrollment{StudentID=5,CourseID=550,Grade=Grades.C},
                new Enrollment{StudentID=5,CourseID=556,Grade=Grades.C},
                new Enrollment{StudentID=5,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=5,CourseID=558,Grade=Grades.A},

                new Enrollment{StudentID=6,CourseID=550,Grade=Grades.A},
                new Enrollment{StudentID=6,CourseID=556,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=567,Grade=Grades.B},
                new Enrollment{StudentID=6,CourseID=558,Grade=Grades.C},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
