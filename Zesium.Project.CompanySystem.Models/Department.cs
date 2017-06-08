using System;
using Zesium.Project.CompanySystem.Models.Services;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Department
    {
        #region Fields
        private string _name;
        private string _description;
        private bool _isDepartmentActive;
        private int _departmentId;
        #endregion

        #region Constructors
        public Department(int id, string name, string description)
        {
            DepartmentId = id;
            Name = name;
            Description = description;
            IsDepartmentActive = true;
        }

        public Department()
        {
            Name = "Undefined";
            Description = "Departman koji uvek postoji i ne moze da se obrise";
            IsDepartmentActive = true;
            DepartmentId = 0;
        }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        public bool IsDepartmentActive
        {
            get
            {
                return _isDepartmentActive;
            }
            set
            {
                _isDepartmentActive = value;
            }
        }

        public int DepartmentId
        {
            get
            {
                return _departmentId;
            }
            set
            {
                _departmentId = value;
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}
