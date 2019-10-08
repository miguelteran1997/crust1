using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD1.Data
{
    public class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        [ForeignKey("DID")]
        public Departments DeptID { get; set; }

    }
}
