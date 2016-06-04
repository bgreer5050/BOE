using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public abstract class Incident
    {

        public int Id { get; set; }
       
        public string OriginalCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }      
       

        public virtual Employee Employee { get; set; }

    

    }

    [Table("SafetyIncidents")]
    public class SafetyIncident : Incident
    {

    }


    [Table("OtherIncidents")]
    public class OtherIncident : Incident
    {

    }

    [Table("AttendanceIncident")]
    public class AttendanceIncident : Incident
    {
        public decimal Points { get; set; }
    }


}
