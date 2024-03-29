using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БазаДанныхИсправленная.Classes
{
    [Table("numberOfClass")]
    public class NumberOfClass
    {
        [Column("Id_Number_Class")]
        public int Id { get; set; }
        [Column("Number_of_class")]
        public int NumberClass { get; set; }
        [Column("Id_Of_Tasks")]
        public int TasksId { get; set; }
    }
}
