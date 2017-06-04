using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace MyProjectV2.Model
{
    class MyProjectContext : DbContext
    {
        public MyProjectContext(): base("name=MyProjectDB")
        { }
        public DbSet<ticket> tickets { get; set; }
        public DbSet<employe> employes { get; set; }
        public DbSet<contrat> contrats { get; set; }
    }
}
