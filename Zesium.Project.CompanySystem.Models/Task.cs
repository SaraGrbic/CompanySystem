using System;
using System.Data.SqlClient;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Task
    {
        #region Fields
        private string _taskName;
        private TaskState _taskState;
        private DateTime _taskStartTime;
        private DateTime _taskEndTime;
        private int _estimatedWorkingTime;
        private int _remainingWorkingTime;
        private string _taskDescription;
        private string _taskComment;
        private int _taskId;
        private string _tasksEmployee;
        private string _tasksProject;
        #endregion

        #region Constructors
        public Task()
        {

        }
        #endregion

        #region Properties
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }

        public TaskState TaskState
        {
            get { return _taskState; }
            set { _taskState = value; }
        }

        public DateTime TaskStartTime
        {
            get { return _taskStartTime; }
            set { _taskStartTime = value; }
        }

        public DateTime TaskEndTime
        {
            get
            {
                return _taskEndTime;
            }
            set
            {
                _taskEndTime = value;
            }
        }

        public int EstimatedWorkingTime
        {
            get
            {
                return _estimatedWorkingTime;
            }
            set
            {
                _estimatedWorkingTime = value;
            }
        }

        public int RemainingWorkingTime
        {
            get
            {
                return _remainingWorkingTime;
            }
            set
            {
                _remainingWorkingTime = value;
            }
        }

        public string TaskDescription
        {
            get { return _taskDescription; }
            set { _taskDescription = value; }
        }

        public string TaskComment
        {
            get { return _taskComment; }
            set { _taskComment = value; }
        }

        public int TaskId
        {
            get { return _taskId; }
            set { _taskId = value; }
        }

        public string TasksEmployee
        {
            get { return _tasksEmployee; }
            set { _tasksEmployee = value; }
        }

        public string TasksProject
        {
            get
            {
                return _tasksProject;
            }
            set
            {
                _tasksProject = value;
            }
        }
        #endregion

        #region Methods
        public void CreateTask(SqlDataReader reader)
        {
            TaskId = Convert.ToInt32(reader["TaskId"].ToString());
            TaskName = reader["TaskName"].ToString();
            TaskStartTime = Convert.ToDateTime(reader["TaskStartTime"].ToString());
            TaskEndTime = Convert.ToDateTime(reader["TaskEndTime"].ToString());
            EstimatedWorkingTime = Convert.ToInt32(reader["EstimatedWorkingTime"].ToString());
            RemainingWorkingTime = Convert.ToInt32(reader["RemainingWorkingTime"].ToString());
            TaskDescription = reader["TaskDescription"].ToString();
            TaskComment = reader["TaskComment"].ToString();
            switch (Convert.ToInt32(reader["TaskStateId"].ToString()))
            {
                case 1:
                    TaskState = TaskState.To_Do;
                    break;
                case 2:
                    TaskState = TaskState.In_Progres;
                    break;
                case 3:
                    TaskState = TaskState.Done;
                    break;
                case 8:
                    TaskState = TaskState.Canceled;
                    break;
            }
            TasksEmployee = reader["EmployeeName"].ToString() + " " + reader["EmployeeLastName"].ToString();
            TasksProject = reader["ProjectName"].ToString();
        }
        #endregion
    }
}
