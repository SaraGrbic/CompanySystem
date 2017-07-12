using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUi.Models
{
    public class UserTypeNames
    {
        public string Name { get; set; }
        public const string EmployeeType = "Employee";
        public const string ManagerType = "Manager";
        public const string AdminType = "Admin";
    }
}