using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_zarzadzanie_studentami.Models;

namespace Project_zarzadzanie_studentami.Data
{
    public class Project_zarzadzanie_studentamiContext : DbContext
    {
        public Project_zarzadzanie_studentamiContext (DbContextOptions<Project_zarzadzanie_studentamiContext> options)
            : base(options)
        {
        }

        public DbSet<Project_zarzadzanie_studentami.Models.Student> Student { get; set; } = default!;

        public DbSet<Project_zarzadzanie_studentami.Models.Subject> Subject { get; set; } = default!;

        public DbSet<Project_zarzadzanie_studentami.Models.Presence> Presence { get; set; } = default!;
    }
}
