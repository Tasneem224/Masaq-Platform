using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models.Notifications
{
    internal class Notification: BaseOfAllEntity

    {

        public string Body { get; set; } = null!;
        public string Header { get; set; }= null!;
        public DateTime ReadAt { get; set; }
        public bool IsRead { get; set; }





    }
}
