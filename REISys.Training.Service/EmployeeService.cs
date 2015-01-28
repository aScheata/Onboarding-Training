using REISys.Training.Repository.DAL;
using REISys.Training.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REISys.Training.BusinessLayer
{
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository repo;

        public EmployeeService()
        {
            repo = new EmployeeRepository();
        }

        public int Add(EmployeeData employee)
        {
            return repo.Add(MapToEmployeeEntity(employee ));
        }

        public bool Update(EmployeeData employee)
        {
            return repo.Update(MapToEmployeeEntity(employee));
        }

        public void Delete(int employeeId)
        {
             repo.Delete(employeeId);
        }

        public EmployeeData Get(int employeeId)
        {
            return MapToEmployeeData(repo.Get().FirstOrDefault());
        }

        public IEnumerable<EmployeeData> Get()
        {
            return MapToEmployeeDataCollection(repo.Get());
        }

        #region Mappers
        private EmployeeData MapToEmployeeData(Employee empEntity)
        {
            var empData = new EmployeeData();
            empData.FirstName = empEntity.FirstName;
            empData.LastName = empEntity.LastName;
            empData.DateofBirth = empEntity.DateofBirth;
            empData.HireDate = empEntity.HireDate;
            return empData;
        }

        private IEnumerable<EmployeeData> MapToEmployeeDataCollection(IEnumerable<Employee> empEntities)
        {
            var empData = new List<EmployeeData>();
           foreach (var empEntity in empEntities)
           {
               empData.Add(MapToEmployeeData(empEntity));
           }
            return empData;
        }

        private Employee MapToEmployeeEntity(EmployeeData empData)
        {
            var empEntity = new Employee();
            empEntity.FirstName = empData.FirstName;
            empEntity.LastName = empData.LastName;
            empEntity.DateofBirth = empData.DateofBirth;
            empEntity.HireDate = empData.HireDate;
            return empEntity;
        }
      

        #endregion
    }
}
