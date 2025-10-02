using DataAccessLayer.Models.Contents.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Contents.Exams
{
    public class BaseEntityExam
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsAvaliable { get; set; }
        public string? Title { get; set; }

        //public List<Question> Questions { get; set; }


    }
}
