using DataAccessLayer.Models.Contents.Exams;
using DataAccessLayer.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class StudentExam
    {
        public int StudentId { get; set; }

        //[ForeignKey(nameof(StudentId))]
        //public Student Student { get; set; }

        //public int ExamId { get; set; }

        //[ForeignKey(nameof(ExamId))]
        //public Exam Exam { get; set; }

        //public double? Grade { get; set; }
        //public bool IsSubmitted { get; set; }
        //public DateTime? SubmittedAt { get; set; }
    }
}
