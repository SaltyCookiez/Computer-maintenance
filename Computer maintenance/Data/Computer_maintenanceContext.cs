using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Computer_maintenance.Models;

namespace Computer_maintenance.Data
{
    public class Computer_maintenanceContext : DbContext
    {
        public Computer_maintenanceContext (DbContextOptions<Computer_maintenanceContext> options)
            : base(options)
        {
        }

        public DbSet<Computer_maintenance.Models.Orders> Orders { get; set; } = default!;
    }
}
