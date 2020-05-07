using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreCRUD.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName ="Nvarchar(250)")]
        public string Name { get; set; }

        [Column(TypeName = "Nvarchar(100)")]
        public string OfficeLocation { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string EmpCode { get; set; }
    }
}
