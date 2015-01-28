using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using REISys.Training.Repository.Repository;
using REISys.Training.Repository.DAL;

namespace REISys.Traning.Test
{
    [TestClass]
    public class EmployeeRepositoryTest
    {
        private  EmployeeRepository repo;
        [TestInitialize]
        public void Initialize()
        {
            repo = new EmployeeRepository(); ;
        }
        [TestMethod]
        public void TestAddEmployee()
        {
            repo.Add(new Employee()
            {
                FirstName = "Galina",
                LastName = "Worku",
                DateofBirth = new DateTime(1985, 12, 2),
                HireDate = DateTime.Today
            });
        }

        [TestMethod]
        public void TestUpdateEmployee()
        {
            repo.Update(new Employee()
            {
                Id = 1,
                FirstName  = "Joe",
                LastName = "Antonio",
                DateofBirth = new DateTime(1985, 12, 2),
                HireDate = DateTime.Today
            });
        }
         [TestMethod]
        public void TestDeleteEmployee()
        {
            repo.Delete(1);
            repo.Delete(2);
            repo.Delete(3);
        }
        [TestMethod]
         public void TestGetAll()
         {
             
         }
    }
}
