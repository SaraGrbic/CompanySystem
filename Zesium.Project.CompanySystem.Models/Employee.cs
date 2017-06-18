using System;
using System.Collections.Generic;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Employee : User
    {
        #region Fields
        private Dictionary<int, Project> _employeeProjects; //***///
        #endregion

        #region Constructors
        public Employee(string username, string password, string name, string lastname, DateTime dayOfBirth, Gender gender, int id, Department department)
            : base (username, password, name, lastname, dayOfBirth, gender, id, department)
        { 
            EmployeeProjects = new Dictionary<int, Project>();
            UserType = UserType.Employee;
        }
        #endregion

        #region Properties
        public Dictionary<int, Project> EmployeeProjects
        {
            get
            {
                return _employeeProjects;
            }
            set
            {
                _employeeProjects = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {Lastname}";
        }
        #endregion
    }
}
