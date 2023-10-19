using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEg2.Model
{
    [Table("tblBooks")]
   public  class Books
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
    }
}
