using BOE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Employee emp = new Employee();
            emp.FirstName = "Bil2l";
            emp.ClockNo = 6536;

            BOE.DAL.BOEContext db = new BOE.DAL.BOEContext("DefaultConnection");
            db.Employees.Add(emp);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
