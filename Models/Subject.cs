using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace catalogv6.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required,
         MinLength(2, ErrorMessage = "The name must have at least 2 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string Name { get; set; }


        [Required,
         MinLength(2, ErrorMessage = "The name must have at least 2 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string TeacherName { get; set; }

        //one to many
        public Student Student { get; set; }
        //one-to-many
        public ICollection<Grade> Grades { get; set; }
    }
}