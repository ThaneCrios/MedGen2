using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.Models
{
    public class MedGenContext : DbContext
    { 
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Man> People { get; set; }
        public MedGenContext(DbContextOptions<MedGenContext> options)
            : base(options)
        {
        }
    }
}
