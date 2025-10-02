using DataAccessLayer.Models.Contents.Questions;
using DataAccessLayer.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Contents.Exams
{
    public class Exam:BaseOfAllContentEntities
    {

        public int Duration { get; set; }
        public string? Title { get; set; }
        public string? Description{ get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsCompleted { get; set; }
        public bool? Status { get; set; }
        public bool IsAvaliable { get; set; }
        
        //is passed or not
        //public ICollection<Question> questions { get; set; }=new HashSet<Question>();


    }
}
