using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public class Job
    {
        public int Id { get; set; }
        public string OriginalCode { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
