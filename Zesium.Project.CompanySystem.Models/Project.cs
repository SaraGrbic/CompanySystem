using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Zesium.Project.CompanySystem.Models
{
   

    public class Project:Entity
    {
     
        
        public string ProjectName { get; set; }
        public int ProjectPrice { get; set; }
        public ProjectState ProjectState { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public int ProjectManagerId { get; set; }
        public virtual User Manager { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<User> Employees { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public bool Delayed { get; set; }


     



    }
}
