using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiQualityPMO.Models;

namespace MiQualityPMO.Data
{
    public class MiQualityPMOContext : DbContext
    {
        public MiQualityPMOContext (DbContextOptions<MiQualityPMOContext> options)
            : base(options)
        {
        }

        public DbSet<MiQualityPMO.Models.Mqaa> Mqaa { get; set; }

        public DbSet<MiQualityPMO.Models.Copq> Copq { get; set; }

        public DbSet<MiQualityPMO.Models.Btp> Btp { get; set; }
    }
}
