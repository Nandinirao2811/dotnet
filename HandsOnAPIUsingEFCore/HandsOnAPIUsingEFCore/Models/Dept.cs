using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingEFCore.Models
{
    [Table("Dept")]
    public class Dept
    {
        [Key]
        public int Did { get; set; }
        [StringLength(30)]

        public string Dname { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
