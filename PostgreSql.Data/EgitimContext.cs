using PostgreSql.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSql.Data
{
    public class EgitimContext : DbContext
    {
        public EgitimContext()
            :base("Name=EgitimContext")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Kullanici> Kullanici { get; set; }
    }
}
