using System.ComponentModel.DataAnnotations;

namespace APISemana11A.Models
{
    public class Enrrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public DateTime Date { get; set; }

        // Crear llavae foranea

        public int CourseID { get; set; }
        public Course Course { get; set; }

       
    }
}
