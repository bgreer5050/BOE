using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public int ClockNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }



    }


    public class SalariedEmployee:Employee
    {

    }

    public class HourlyEmployee:Employee
    {
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}
