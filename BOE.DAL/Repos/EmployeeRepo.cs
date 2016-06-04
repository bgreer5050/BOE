using BOE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOE.DAL.Repos
{
    public class EmployeeRepo 
    {
        private BOE.DAL.BOEContext db;

        public EmployeeRepo(BOE.DAL.BOEContext db)
        {
            db = new BOEContext();
        }

       

        public Employee GetHourlyEmployeeByClockNo(int ClockNo)
        {
            return db.HourlyEmployees.Where(c => c.ClockNo == ClockNo).FirstOrDefault();
        }

        public Employee GetSalariedEmployeeByClockNo(int ClockNo)
        {
            return db.SalariedEmployees.Where(c => c.ClockNo == ClockNo).FirstOrDefault();
        }

        public IQueryable<HourlyEmployee> GetHourlyEmployees()
        {
            return db.HourlyEmployees;
        }

        public IQueryable<SalariedEmployee> GetSalariedEmployees()
        {
            return db.SalariedEmployees;
        }


        public ICollection<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.AddRange(db.SalariedEmployees.ToList());
            employees.AddRange(db.HourlyEmployees.ToList());

            return employees;
        }

        public void CreateHourlyEmployee(HourlyEmployee hourlyEmployee)
        {
            db.HourlyEmployees.Add(hourlyEmployee);
            db.SaveChanges();
        }

        public void CreateSalariedEmployee(SalariedEmployee salariedEmployee)
        {
            db.SalariedEmployees.Add(salariedEmployee);
            db.SaveChanges();
        }

        public void UpdateHourlyEmployee(HourlyEmployee hourlyEmployee)
        {
            db.Entry<HourlyEmployee>(hourlyEmployee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public void UpdateSalariedEmployee(SalariedEmployee salariedEmployee)
        {
            db.Entry<SalariedEmployee>(salariedEmployee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }


    }
}
