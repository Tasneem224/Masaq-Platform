using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    internal class BaseOfAllEntity
    {
        public int Id { get; set; }//PK
        public int CreatedBy { get; set; }// UserId
        public DateTime? CreatedOn { get; set; }// Date
        public int LastModifiedBy { get; set; }// UserId
        public DateTime LastModifiedOn { get; set; }// Date
        public bool IsDeleted { get; set; }// Soft Delete
    }
}
