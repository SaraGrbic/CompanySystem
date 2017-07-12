using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zesium.Project.CompanySystem.Models;

namespace WebUi.Models
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public int ProjectPrice { get; set; }
        public ProjectState ProjectState { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        public int ProjectManagerId { get; set; }  
        public int DepartmentId { get; set; }
        public bool Deleyed { get; set; }
    }
}