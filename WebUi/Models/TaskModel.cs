using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Models
{
    public class TaskModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
    }
}