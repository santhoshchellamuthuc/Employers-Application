using EmployerApplications.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerApplications
{
    public class Employerscontext:DbContext
    {
        public Employerscontext(DbContextOptions parameter) : base(parameter)
        {

        }
        public virtual DbSet<Employersdetils> EmployersApplication { get; set; }

    }
}
