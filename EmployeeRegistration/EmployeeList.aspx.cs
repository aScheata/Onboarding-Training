using REISys.Training.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeRegistration
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var svc = new EmployeeService();
            var employees = svc.Get();
            
              grdEmployees.DataSource = employees;
              grdEmployees.DataBind();
           
        }
    }
}