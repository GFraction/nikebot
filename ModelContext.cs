using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nikebot
{
    class ModelContext : DbContext
    {
        public ModelContext(): base("DbConnection") { }
        public DbSet<Profile> ProfList { get; set; }
       
    }
}
