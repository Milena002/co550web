using ContosoUniversity.Data;
using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RazorContoso.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var tabby = new Student
            {
                StudentID=71,
                FirstName = "Leo",
                LastName = "Tabby",
                EnrollmentDate = DateTime.Parse("2022-09-01")
            };

            var ciesla = new Student
            {
                StudentID=72,
                FirstName = "Dawid",
                LastName = "Ciesla",
                EnrollmentDate = DateTime.Parse("2022-09-06")
            };

            var iwko = new Student
            {
                StudentID=73,
                FirstName = "Igor",
                LastName = "Iwko",
                EnrollmentDate = DateTime.Parse("2022-09-09")
            };

            var marchlewska = new Student
            {
                StudentID = 74,
                FirstName = "Natalia",
                LastName = "Marchlewska",
                EnrollmentDate = DateTime.Parse("2022-10-01")
            };

            var michalska = new Student
            {
                StudentID=75,
                FirstName = "Maja",
                LastName = "Michalska",
                EnrollmentDate = DateTime.Parse("2022-09-23")
            };

            var lawska = new Student
            {
                StudentID=76,
                FirstName = "Ola",
                LastName = "Lawska",
                EnrollmentDate = DateTime.Parse("2022-09-01")
            };

            var courses = new Course[]
         {
                new Course{CourseID=556,CourseCode="CO556", Title="Network Systems",Credits=3},
                new Course{CourseID=550,CourseCode="CO550", Title="Web Applications",Credits=3},
                new Course{CourseID=558,CourseCode="CO558", Title="Database Design",Credits=3},
                new Course{CourseID=567,CourseCode="CO567", Title="Object Oriented SD",Credits=4},
           
         };

            context.Courses.AddRange(courses);


            var enrollments = new Enrollment[]
            {
                new Enrollment

                {  
                    EnrollmentID=2,
                    Student = tabby,
                    CourseID=556,
                    Grade= Grades.B
                },
                new Enrollment
                {
                    EnrollmentID=3,
                    Student = ciesla,
                    CourseID=556,
                    Grade = Grades.C
                },
                new Enrollment
                {
                    EnrollmentID=4,
                    Student = iwko,
                    CourseID=556,
                    Grade = Grades.A
                },
                new Enrollment
                {
                    EnrollmentID=5,
                    Student = michalska,
                      CourseID=556,
                    Grade = Grades.F
                },
                new Enrollment
                {
                    EnrollmentID = 6,
                    Student = marchlewska,
                    CourseID=556,
                    Grade = Grades.D
                },
                new Enrollment
                {
                    EnrollmentID=7,
                    Student = lawska,
                    CourseID=556,
                    Grade = Grades.B
                },

//CO550
                new Enrollment
                {
                    Student = tabby,
                    CourseID=550,
                    Grade= Grades.D
                },
                new Enrollment
                {
                    Student = ciesla,
                    CourseID=550,
                    Grade = Grades.A
                },
                new Enrollment
                {
                    Student = iwko,
                    CourseID=550,
                    Grade = Grades.B
                },
                new Enrollment
                {
                    Student = michalska,
                      CourseID=550,
                    Grade = Grades.F
                },
                new Enrollment
                {
                    Student = marchlewska,
                      CourseID=550,
                    Grade = Grades.A
                },
                new Enrollment
                {
                    Student = lawska,
                      CourseID=550,
                    Grade = Grades.B
                },

///CO558
                new Enrollment
                {
                    Student = tabby,
                    CourseID=558,
                    Grade= Grades.B
                },
                new Enrollment
                {
                    Student = ciesla,
                    CourseID=556,
                    Grade = Grades.C
                },
                new Enrollment
                {
                    Student = iwko,
                    CourseID=556,
                    Grade = Grades. A
                },
                new Enrollment
                {
                    Student = michalska,
                      CourseID=556,
                    Grade = Grades.D
                },
                new Enrollment
                {
                    Student = marchlewska,
                      CourseID=556,
                    Grade = Grades.B
                },
                new Enrollment
                {
                    Student = lawska,
                      CourseID=556,
                    Grade = Grades.A
                },



///CO567
                new Enrollment
                {
                    Student = tabby,
                    CourseID=567,
                    Grade= Grades.A
                },
                new Enrollment
                {
                    Student = ciesla,
                    CourseID=567,
                    Grade = Grades.B
                },
                new Enrollment
                {
                    Student = iwko,
                    CourseID=567,
                    Grade = Grades.C
                },
                new Enrollment
                {
                    Student = michalska,
                      CourseID=567,
                    Grade = Grades.A
                },
                new Enrollment
                {
                    Student = marchlewska,
                      CourseID=567,
                    Grade = Grades.F
                },
                new Enrollment
                {
                    Student = lawska,
                      CourseID=567,
                    Grade = Grades.B
                },

            };

            context.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}