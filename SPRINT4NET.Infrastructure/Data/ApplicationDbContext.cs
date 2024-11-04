using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SPRINT4NET.Domain.Entities;

namespace SPRINT4NET.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<URLAnalise> URLAnalises { get; set; }
        // Adicione outras DbSets para suas entidades
    }
}
