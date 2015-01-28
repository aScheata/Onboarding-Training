using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EmployeeData
    {

         public EmployeeData()
        {
            this.Addresses = new HashSet<AddressData>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<DateTime> DateofBirth { get; set; }
        public Nullable<DateTime> HireDate { get; set; }
    
        public  ICollection<AddressData> Addresses { get; set; }
    }
}
