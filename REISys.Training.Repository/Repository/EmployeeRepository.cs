using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REISys.Training.Repository.DAL;

namespace REISys.Training.Repository.Repository
{
 
    /// <summary>
    /// Employee repository class
    /// </summary>
    public class EmployeeRepository : IDisposable 
    {

        private readonly OnboardingContext ctx;
        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeRepository()
        {
            ctx = new OnboardingContext();
        }
        
        /// <summary>
        /// Adds new employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>The newly created employee id</returns>
        public int  Add(Employee employee)
        {
           
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
                return employee.Id;
            
        }
        /// <summary>
        /// Updates existing employee record
        /// </summary>
        /// <param name="employee"></param>
        public bool Update(Employee employee)
        {
            using (OnboardingContext ctx = new OnboardingContext())
            {
              
                var updatedEmployee = ctx.Employees.Find(employee.Id );
                if(updatedEmployee != null)
                {
                    //entity is already in the context
                    var attachedEntry = ctx.Entry(updatedEmployee);
                    attachedEntry.CurrentValues.SetValues(employee );
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Deletes Employee record
        /// </summary>
        /// <param name="empId"></param>
        public void Delete(int empId)
        {
            using (OnboardingContext ctx = new OnboardingContext())
            {

                var employeeToDelete = ctx.Employees.Find(empId);
                if (employeeToDelete != null)
                {
                    //entity is already in the context
                    var attachedEntry = ctx.Entry(employeeToDelete).Entity;
                    ctx.Employees.Remove(attachedEntry);
                    ctx.SaveChanges();
                }
            }
        }

        /// <summary>
        /// gets all employees
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Employee> Get()
        {
            return ctx.Employees.ToList();
        }
        /// <summary>
        /// Dispose the database context
        /// </summary>
        public void Dispose()
        {
            if (ctx != null)
            {
                ctx.Dispose();
            }
        }
    }
}
