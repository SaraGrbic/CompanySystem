using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using Zesium.Project.CompanySystem.Models.Services;

namespace Zesium.Project.CompanySystem.Models
{
   
    public class Department:Entity
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDepartmentActive { get; set; }
        public int? ManagerId { get; set; }
        public virtual User Manager { get; set; }
        public virtual ICollection<User> Emloyees { get; protected set; }

      

    }
}
