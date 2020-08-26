using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FIT5032_W04_CodeFirst.Models
{
    public class EmployeeDetailsContext : DbContext
    {
        public EmployeeDetailsContext() : base("DefaultConnection")

        {

        }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

    }
}