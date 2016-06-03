using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public class Qualification
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Job Job { get; set; }
        public virtual Employee Employee { get; set; }


        

    }
}
