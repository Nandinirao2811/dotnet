using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingEFCore.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [StringLength(30)]
        public string Ename { get; set; }
        public DateTime? JoinDate { get; set; }
        public string Desig { get; set; }
        public double? Sal { get; set; }
        [ForeignKey("Dept")]
        public int Did { get; set; }
        public Dept Dept { get; set; }

    }
}
