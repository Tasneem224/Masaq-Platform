using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Levels
{
    public class Level:BaseOfAllContentEntities
    {

        public int LevelNumber { get; set; }
        public int NumberOfStudents { get; set; }
        public string AcademicYear { get; set; }
    }
}
