using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample1
{
    [Table("MyBooks")]
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(60)]
        public string Title { get; set; }
        public string Publisher { get; set; }
    }
}
