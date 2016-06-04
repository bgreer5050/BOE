using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.DAL.Repos
{
    
    public class IncidentRepo
    {
        private BOE.DAL.BOEContext db;

        public IncidentRepo(BOE.DAL.BOEContext db)
        {
            this.db = new BOEContext();
        }

    }
}
