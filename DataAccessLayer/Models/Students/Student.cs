using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Students
{
    public class Student:HumanBaseEntity
    {

        public int Grade { get; set; }


        [Phone]
        public String PhoneNumber { get; set; } = null!;

        [Phone]
        public String ParentPhoneNumber { get; set; } = null!;
        public int CreationBy { get; set; }
        //public bool favorite { get; set; }  
        public DateTime CreatedOn { get; set; }
        public DateTime LastModified { get; set; }

        //public ICollection<StudentExam> studentExams { get; set; }= new HashSet<StudentExam>();
        //public ICollection<StudentLesson> studentLessons { get; set; } = new HashSet<StudentLesson>();
    }
}
