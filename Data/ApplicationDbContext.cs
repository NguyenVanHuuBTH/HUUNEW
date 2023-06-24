using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CUONGDB.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CUONGDB.Models.LOPHOC> LOPHOC { get; set; } = default!;

        public DbSet<CUONGDB.Models.HUU> HUU { get; set; } = default!;
    }
