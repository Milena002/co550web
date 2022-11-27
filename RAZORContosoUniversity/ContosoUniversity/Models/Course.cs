using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string CourseCode { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
