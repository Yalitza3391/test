using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity.Modelos
{
    public class Table2
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }
        [ForeignKey(nameof(Table1))]
        public int IdT1 { get; set; }

        public virtual Table1 Table1 { get; set; }
    }
}
