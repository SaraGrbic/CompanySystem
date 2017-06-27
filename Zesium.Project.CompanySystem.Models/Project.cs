using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        private User _projectManager;
        private Department _department;
        private Dictionary<int, Employee> _projectEmployees;
        private Dictionary<int, Task> _projectTasks;
        private int _projectId;
        private bool _delayed;
        #endregion

        #region Constructors
        public Project()
        {

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

        public User ProjectManager
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
                //_delayed = DateTime.Now > ProjectEndDate;
                return _delayed;
            }
            set
            {
                _delayed = value;
            }
        }
        #endregion

        #region Methods
        public void CreateProject(SqlDataReader reader)
        {
            ProjectId = Convert.ToInt32(reader["ProjectId"].ToString());
            ProjectName = reader["ProjectName"].ToString();
            ProjectPrice = Convert.ToInt32(reader["ProjectPrice"].ToString());
            ProjectDescription = reader["ProjectDescription"].ToString();
            ProjectStartDate = Convert.ToDateTime(reader["ProjectStartDate"].ToString());
            ProjectEndDate = Convert.ToDateTime(reader["ProjectEndDate"].ToString());
            if (Convert.ToBoolean(reader["IsProjectDelayed"]))
            {
                Delayed = true;
            }
            else
            {
                Delayed = false;
            }
            switch(Convert.ToInt32(reader["ProjectStateId"].ToString()))
            {
                case 1:
                    ProjectState = ProjectState.New;
                    break;
                case 2:
                    ProjectState = ProjectState.InProgres;
                    break;
                case 3:
                    ProjectState = ProjectState.Finished;
                    break;
                case 4:
                    ProjectState = ProjectState.Canceled;
                    break;
            }

            User user = new User();
            user.CreateUser(reader);

            ProjectManager = user;
            
            Department = user.Department;
        }

        public override string ToString()
        {
            return ProjectName;
        }
        #endregion




    }
}
