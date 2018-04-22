using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzADO.NET
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        [ForeignKey("Person")]
        public int? PersonId { get; set; }
        public Person Person { get; set; }
        public ICollection<AuthorBooks> AuthorsBooks { get; set; }
    }
}
