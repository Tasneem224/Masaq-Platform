using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Announcements
{
    internal class Announcement:BaseOfAllEntity
    { 
        public string Header { get; set; }= null!;
        public string Body { get; set; }= null!;
        public bool IsPinned { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime CreateModifieddOn { get; set; }
        public int CreateModifieddBy { get; set; }//id
        public bool IsDeleted { get; set; }

    }
}
