using REISys.Training.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeRegistration
{
    public partial class RegisterEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            EmployeeData empData = new EmployeeData();
            empData.FirstName = txtFirstName.Text;
            empData.LastName = txtLastName.Text;

            var svc = new EmployeeService();
            svc.Add(empData);

          
        }
    }
}