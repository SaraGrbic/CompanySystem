using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Models
{
    public class TaskViewModel
    {
        //public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public string TaskName { get; set; }

        public TaskState TaskState { get; set; }

        public DateTime TaskStartTime { get; set; }

        public DateTime TaskEndTime { get; set; }

        public int EstimatedWorkingTime { get; set; }

        public int RemainingWorkingTime { get; set; }

        public string TaskDescription { get; set; }

        public string TaskComment { get; set; }

       

      
    }
}