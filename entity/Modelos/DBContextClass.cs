using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Modelos
{
    public class DBContextClass:DbContext
    {
        public DBContextClass() : base("Test")
        {
           // Database.SetInitializer<CultivoPinaDBContext>(new CultivoPinaSeedBasedeDatos());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Table2> table2s { get; set; }
        public DbSet<Table1> table1s { get; set; }

       // public System.Data.Entity.DbSet<WEBTABLES.Table1ViewModel> Table1ViewModel { get; set; }
    }
}
