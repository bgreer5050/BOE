using BOE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.DAL
{
    public class BOEContext : DbContext
    {

        public BOEContext()
      : base("DefaultConnection")
        {

        }

        public BOEContext(string connectionStringName)
      : base("DefaultConnection")
    {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
