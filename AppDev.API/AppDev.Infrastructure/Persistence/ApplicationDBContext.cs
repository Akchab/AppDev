using AppDev.Application.Common.Interface;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

 
using AppDev.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDev.Domain.Entities;

namespace AppDev.Infrastructure.Persistence
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser, IdentityRole, string>,
        IApplicationDBContext
    {
        private readonly IDateTime _dateTime;
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options,
            IDateTime dateTime) : base(options)
        {
            _dateTime = dateTime;
        }
        public DbSet<Employee> Employee { get; set; }
    }

}