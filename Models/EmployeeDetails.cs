using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class EmployeeDetails
    {
        [Key]

        public int EmpID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public Nullable<int> Age { get; set; }

        public Nullable<decimal> Salary { get; set; }

        public string worktype { get; set; }
    }
}