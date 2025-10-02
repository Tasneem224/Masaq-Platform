using DataAccessLayer.Models.Contents.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Contents.Lessons
{
    internal class Lesson:BaseEntityExam
    {
       
        public string Description { get; set; }
        public string? ImageName { get; set; }
        public string? VideoName { get; set; }
        public string? DocName { get; set; }
        //public ICollection<StudentLesson> studentLessons { get; set; } = new HashSet<StudentLesson>();


    }
}
