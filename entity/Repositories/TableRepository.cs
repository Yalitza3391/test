using entity.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Repositories
{
    public class TableRepository : TestRepository<Table1>
    {
        public TableRepository(DBContextClass context)
         : base(context)
        {
        }

        public override IQueryable<Table1> All()
        {
            return this.Context.table1s.AsNoTracking();
        }

        public override IQueryable<Table1> AllWithTracking()
        {
            return this.Context.table1s;
        }

        protected override Table1 MapNewValuesToOld(Table1 oldEntity, Table1 newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
