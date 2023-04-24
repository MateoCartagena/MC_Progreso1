using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MC_Progreso1.Models;

namespace MC_Progreso1.Data
{
    public class MC_DBBContext : DbContext
    {
        public MC_DBBContext (DbContextOptions<MC_DBBContext> options)
            : base(options)
        {
        }

        public DbSet<MC_Progreso1.Models.MCartagena> MCartagena { get; set; } = default!;
    }
}
