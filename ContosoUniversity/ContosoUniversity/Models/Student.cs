using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{ 
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; } = String.Empty;

        public string FirstName { get; set; } = String.Empty;
        public DateTime EnrollmentDate { get; set; }
        // Relationships or navigation propeties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
    
}
