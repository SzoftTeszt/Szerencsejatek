using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrar.Data
{
    public class Context : DbContext
    {
        public Context(){}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=API.Data;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ClassLibrar.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrar.Models.Tipp>? Tipp { get; set; }
    }
}
