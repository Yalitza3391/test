using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace entity.Modelos
{
    public class Table1
    {
        [Key]
        public int IdT1 { get; set; }
        public string Name { get; set; }
    }
}
