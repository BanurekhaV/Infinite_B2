using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEg2.Model
{
    [Table("tblAuthors")]
   public class Authors
    {
        [Key]
        public int AuthorID { get; set; }
        
        public string AuthorName { get; set; }
    }
}
