using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KieuVanThang341.Models;
using KVT0341.Models;

namespace KieuVanThang341.Data
{
    public class KieuVanThang341Context : DbContext
    {
        public KieuVanThang341Context (DbContextOptions<KieuVanThang341Context> options)
            : base(options)
        {
        }

        public DbSet<KieuVanThang341.Models.KVT341> KVT341 { get; set; }

        public DbSet<KVT0341.Models.KVT0341> KVT0341 { get; set; }
    }
}
