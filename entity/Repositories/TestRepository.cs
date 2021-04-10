using entity.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Repositories
{
   

        public abstract class TestRepository<TEntity> : RepositoryBase<TEntity, DBContextClass>
        where TEntity : class
        {
            public TestRepository(DBContextClass context)
                : base(context)
            {
                this.Context = context;
            }
        }
    
}
