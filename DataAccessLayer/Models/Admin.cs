using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class Admin
    {
        public int Id { get; set; } 
        public string FName { get; set; }
        public string LName { get; set; }
        public Gender Gender { get; set; }
        public string email { get; set; }
    }
}
