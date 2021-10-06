using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KieuVanThang341.Models;

namespace KieuVanThang341.Data
{
    public class KieuVanThang341Context : DbContext
    {
        public KieuVanThang341Context (DbContextOptions<KieuVanThang341Context> options)
            : base(options)
        {
        }

        public DbSet<KieuVanThang341.Models.KVT341> KVT341 { get; set; }
    }
}
