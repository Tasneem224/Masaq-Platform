using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Announcements
{
    public class Announcement:BaseOfAllContentEntities
    { 
        public string Header { get; set; }= null!;
        public string Body { get; set; }= null!;
        public bool IsPinned { get; set; }
       

    }
}
