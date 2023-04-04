using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev.Domain.Shared
{
    public abstract class BaseEntity
    {
        public DateTime CreatedTime { get; set; }

        public DateTime? LastModifiedTime { get; set;}
        public DateTime? DeletedTime { get; set; }  
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }

        public int DeletedBy { get; set; }

        public int IsDeleted { get; set; }
    }
}
