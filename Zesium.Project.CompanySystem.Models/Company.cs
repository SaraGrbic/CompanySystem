using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public sealed class Company
    {
        #region Constants
        private const string FILE_PATH = @"C:\Users\Coja\Desktop\CompanySystem.bin";
        #endregion Constants

        #region Fields
        private Dictionary<int, User> _users;
        private Dictionary<int, Department> _departments;
        private Dictionary<int, Project> _projects;
        private User _currentUser;
        private static Company _company;
        #endregion

        #region Constructors
        private Company()
        {
            Users = new Dictionary<int, User>();
            Departments = new Dictionary<int, Department>();
            Department firstDepartment = new Department();
            Departments.Add(firstDepartment.DepartmentId, firstDepartment);
            Projects = new Dictionary<int, Project>();
            Administrator admin = new Administrator();
            admin.Department = firstDepartment;
            Users.Add(admin.Id, admin);
        }
        #endregion

        #region Properties
        public Dictionary<int, User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public Dictionary<int, Department> Departments
        {
            get { return _departments; }
            set { _departments = value; }
        }

        public Dictionary<int, Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }

        public User CurrentUser
        {
            get { return _currentUser; }
            set { _currentUser = value; }
        }

        public static Company Instance
        {
            get
            {
                if (_company == null)
                {
                    _company = new Company();
                    _company.ReadFromBinaryOrCreate();
                }

                return _company;
            }
        }
        #endregion

        #region Methods
        public void SaveInBinary(Company company)
        {
            FileStream fs = new FileStream(FILE_PATH, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fs, company);
            fs.Close();
        }

        public Company ReadFromBinaryOrCreate()
        {
            
            if (!File.Exists(FILE_PATH))
            {
                SaveInBinary(_company);
            }
            else
            {
                FileStream fs = new FileStream(FILE_PATH, FileMode.Open, FileAccess.Read);
                BinaryFormatter deserializer = new BinaryFormatter();
                _company = (Company)deserializer.Deserialize(fs);
                fs.Close();
            }
            return _company;
        }
        #endregion
    }
}
