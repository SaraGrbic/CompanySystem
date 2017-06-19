using System;
using System.Collections.Generic;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Project
    {
        #region Fields
        private string _projectName;
        private int _pojectPrice;
        private ProjectState _projectState;
        private string _projectDescription;
        private DateTime _projectStartDate;
        private DateTime _projectEndDate;
        private Manager _projectManager;
        private Department _department;
        private Dictionary<int, Employee> _projectEmployees;
        private Dictionary<int, Task> _projectTasks;
        private int _projectId;
        #endregion

        #region Constructors
        public Project(int projectId, string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate, Manager projectManager, Department department)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            ProjectPrice = projectPrice;
            ProjectState = ProjectState.New;
            ProjectDescription = projectDescription;
            ProjectStartDate = projectStartDate;
            ProjectEndDate = projectEndDate;
            ProjectManager = projectManager;
            Department = department;
            ProjectEmployees = new Dictionary<int, Employee>();
            ProjectTasks = new Dictionary<int, Task>();
        }
        #endregion

        #region Properties
        public string ProjectName
        {
            get { return _projectName; }
            set { _projectName = value; }
        }

        public int ProjectPrice
        {
            get { return _pojectPrice; }
            set { _pojectPrice = value; }
        }

        public ProjectState ProjectState
        {
            get { return _projectState; }
            set { _projectState = value; }
        }

        public string ProjectDescription
        {
            get { return _projectDescription; }
            set { _projectDescription = value; }
        }

        public DateTime ProjectStartDate
        {
            get { return _projectStartDate; }
            set { _projectStartDate = value; }
        }

        public DateTime ProjectEndDate
        {
            get { return _projectEndDate; }
            set { _projectEndDate = value; }
        }

        public Manager ProjectManager
        {
            get
            {
                return _projectManager;
            }
            set
            {
                _projectManager = value;
            }
        }

        public Department Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public Dictionary<int, Employee> ProjectEmployees
        {
            get { return _projectEmployees; }
            set { _projectEmployees = value; }
        }

        public Dictionary<int, Task> ProjectTasks
        {
            get { return _projectTasks; }
            set { _projectTasks = value; }
        }

        public int ProjectId
        {
            get
            {
                return _projectId;
            }
            set
            {
                _projectId = value;
            }
        }

        public bool Delayed
        {
            get
            {
                return DateTime.Now > ProjectEndDate;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return ProjectName;
        }
        #endregion




    }
}
