using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Levels
{
    internal class Level
    {
        public int id { get; set; }
        public int LevelNumber { get; set; }
        public int NumberOfStudents { get; set; }
        public int AcademicYear { get; set; }
    }
}
