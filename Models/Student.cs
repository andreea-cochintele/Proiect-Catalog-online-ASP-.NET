using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace catalogv6.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }

        [Required,
         MinLength(2, ErrorMessage = "The name must have at least 2 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string Name { get; set; }

        [Required,
         MinLength(5, ErrorMessage = "Must have at least 5 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string Faculty { get; set; }

        [Required,
         MinLength(2, ErrorMessage = "The name must have at least 2 characters."),
         MaxLength(100, ErrorMessage = "This name seems to be too long...")]
        public string Specialization { get; set; }

        [Required,
         RegularExpression(@"^\d+$")]
        public int Group { get; set; }

        //one to many
        public Grade Grade { get; set; }

        // one-to-many relationship

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }

    }
}