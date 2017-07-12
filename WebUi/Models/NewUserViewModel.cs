using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zesium.Project.CompanySystem.Models;
namespace WebUi.Models
{
    public class NewUserViewModel
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public Gender Gender { get; set; }

        public int Id { get; set; }

        public int DepartmentId { get; set; }
     
        public virtual IEnumerable<SelectListItem> Department { get; set; }

        public UserType UserType { get; set; }

     
    }
}