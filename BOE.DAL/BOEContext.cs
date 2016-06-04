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

        public DbSet<SalariedEmployee> SalariedEmployees { get; set; }
        public DbSet<HourlyEmployee> HourlyEmployees { get; set; }

        public DbSet<SafetyIncident> SafetyIncidents { get; set; }
        public DbSet<AttendanceIncident> AttendanceIncidents { get; set; }
        public DbSet<OtherIncident> OtherIncidents { get; set; }

        public DbSet<EducationExternal> EducationExternals { get; set; }
        public DbSet<EducationInternal> EducationInternals { get; set; }

        public DbSet<EducationLog> EducationLogs { get; set; }
    }
}
