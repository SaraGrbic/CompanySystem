using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUi.Models
{
    public class DepartmentEmployeesViewModel
    {
        public int DepartmentId { get; set; }
        public IEnumerable<UserTypeViewModel> Employees { get; set; }
    }
}