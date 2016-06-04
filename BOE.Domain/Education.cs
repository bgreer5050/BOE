using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.Domain
{
    public abstract class Education
    {
        public int  Id { get; set; }
        public string AS400Code { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

    }


    public class EducationInternal : Education
    {

    }

    public class EducationExternal : Education
    {

    }
}
