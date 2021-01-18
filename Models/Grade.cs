using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace catalogv6.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }

        [Required,
         MinLength(2, ErrorMessage = "The name must have at least 2 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string SubjectName { get; set; }

        [Required,
         RegularExpression(@"\d")]
        public int Value { get; set; }

        public virtual Subject Subject { get; set; }
        //one to many
        public ICollection<Student> Student { get; set; }

    }
}