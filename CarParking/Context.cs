using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParking
{
    internal class Context : DbContext
    {
        public DbSet<Bilgiler>Araç{ get; set; }

        public DbSet<AdminBilgiler>Admin { get; set; }
        public DbSet<ArabaÜcretler>Ücret{ get; set; }
    }

}
