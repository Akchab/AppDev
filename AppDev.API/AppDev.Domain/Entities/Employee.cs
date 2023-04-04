using AppDev.Domain.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDev.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }

        public DateTime JoinDate { get; set; }
        public string? Name { get; set; }

        public string? Contact { get; set; }

        public string? Address { get; set; }

        public string? Designation { get; set; }

        
    }
}
