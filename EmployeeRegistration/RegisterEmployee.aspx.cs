using BusinessLayer;
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
            if (!string.IsNullOrEmpty(txtBirthDate.Text))
            {
                empData.DateofBirth = DateTime.Parse(txtBirthDate.Text);
            }
            if (!string.IsNullOrEmpty(txtHireDate.Text))
            {
                empData.HireDate = DateTime.Parse(txtHireDate.Text);
            }
            var svc = new EmployeeService();
           var id =  svc.Add(empData);
           lblSuccess.Text = "Employee Record created successfuly. Employee Id: " + id;

          
        }
        protected void Clear_Click(object sender, EventArgs e)
        {
           
           txtFirstName.Text ="";
           txtLastName.Text="";
           txtBirthDate.Text = "";
           lblSuccess.Text = "";
           txtHireDate.Text = "";
          


        }

    }
}