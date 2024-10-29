using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PérezJosé_Progreso1.Models;

namespace PérezJosé_Progreso1.Data
{
    public class PérezJosé_Progreso1Context : DbContext
    {
        public PérezJosé_Progreso1Context (DbContextOptions<PérezJosé_Progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<PérezJosé_Progreso1.Models.Celular> Celular { get; set; } = default!;
        public DbSet<PérezJosé_Progreso1.Models.PerezJ> PerezJ { get; set; } = default!;
    }
}
