using System;
using System.Collections.Generic;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Manager : User
    {
        #region Fields
        private Dictionary<int, Project> _managerProjects;
        #endregion

        #region Constructors
        public Manager(User user, Department department)
        {
            Username = user.Username;
            Password = user.Password;
            Name = user.Name;
            LastName = user.LastName;
            DayOfBirth = user.DayOfBirth;
            Gender = user.Gender;
            Id = user.Id;
            Department = department;
            UserType = UserType.Manager;
            ManagerProjects = new Dictionary<int, Project>();

        }
        #endregion

        #region Properties
        public Dictionary<int, Project> ManagerProjects
        {
            get
            {
                return _managerProjects;
            }
            set
            {
                _managerProjects = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
        #endregion
    }
}
