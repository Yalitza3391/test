using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTest.Table1
{
    public interface ITable1
    {
        IEnumerable<entity.Modelos.Table1> GetCultivoProductivo();
    }
}
