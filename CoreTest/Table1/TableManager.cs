using entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTest.Table1
{
     public class TableManager:ITable1
     {
        private readonly IRepository<entity.Modelos.Table1> table1Repository;
        public TableManager(IRepository<entity.Modelos.Table1> table1Repository)
        {
            this.table1Repository = table1Repository;
        }

        public IEnumerable<entity.Modelos.Table1> GetCultivoProductivo()
        {
            var data = this.table1Repository.All().ToList();
            return data;
        }

    }
}
