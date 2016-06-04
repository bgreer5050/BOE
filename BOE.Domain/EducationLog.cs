using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
   public  class EducationLog
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Education Education { get; set; }
        public string Status { get; set; }
        public DateTime StausDate { get; set; }
        public string Notes { get; set; }
    }
}
