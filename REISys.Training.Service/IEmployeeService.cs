using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REISys.Training.BusinessLayer
{
   public  interface IEmployeeService
    {
       int Add(EmployeeData employee);

       bool Update(EmployeeData employee);
       
       void Delete(int employeeId);
       
       EmployeeData Get(int employeeId);

       IEnumerable<EmployeeData> Get();


    }
}
