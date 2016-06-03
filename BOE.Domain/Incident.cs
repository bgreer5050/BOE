using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public class Incident
    {

        public int Id { get; set; }
        public decimal Points { get; set; }
        public string OriginalCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool IsAttendance { get; set; }
        public bool IsSafety { get; set; }
        public bool IsVerbalWarning { get; set; }
        public bool IsWrittenWarning { get; set; }


        public virtual Employee Employee { get; set; }

    

    }
}
