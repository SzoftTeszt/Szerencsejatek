using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrar.Models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<ClassLibrar.Models.Jatekos> Jatekos { get; set; } = default!;

        public DbSet<ClassLibrar.Models.Tipp>? Tipp { get; set; }
    }
}
