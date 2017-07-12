using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace Zesium.Project.CompanySystem.Models
{
   
    public class Task:Entity
    {
       
        public string TaskName { get; set; }

        public TaskState TaskState { get; set; }

        public DateTime TaskStartTime { get; set; }

        public DateTime TaskEndTime { get; set; }

        public int EstimatedWorkingTime { get; set; }

        public int RemainingWorkingTime { get; set; }

        public string TaskDescription { get; set; }

        public string TaskComment { get; set; }  

        //public string TaskEmployee { get; set; }

       
        public virtual User Employee { get; set; }
        public virtual User AssignedEmployee { get; set; }

        public int EmployeeId { get; set; }

        public virtual Project TasksProject { get; set; }

        public int ProjectId { get; set; }





    }
}
