using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Context : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Singer> Singers { get; set; }
    }
}
