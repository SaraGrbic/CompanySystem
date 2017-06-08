using System;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Task
    {
        #region Fields
        private string _taskName;
        private TaskState _taskState;
        private DateTime _taskStartTime;
        private string _taskDescription;
        private string _taskComment;
        private int _taskId;
        private Employee _tasksEmployee;
        private Project _tasksProject;
        #endregion

        #region Constructors
        public Task(int taskId, string taskName, DateTime taskStartTime, string taskDescription, Employee taskEmployee, Project tasksProject)
        {
            TaskId = taskId;
            TaskName = taskName;
            TaskState = TaskState.To_Do;
            TaskStartTime = taskStartTime;
            TaskDescription = taskDescription;
            TaskComment = string.Empty;
            TasksEmployee = taskEmployee;
            TasksProject = tasksProject;
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

        public Employee TasksEmployee
        {
            get { return _tasksEmployee; }
            set { _tasksEmployee = value; }
        }


        public Project TasksProject
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
    }
}
