using System;
using System.Data.SqlClient;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class User
    {
        #region Fields
        private string _username;
        private string _password;
        private string _name;
        private string _lastName;
        private DateTime _dayOfBirth;
        private Gender _gender;
        private int _id;
        private Department _department;
        private UserType _type;
        #endregion

        #region Constructors
        public User()
        {

        }

        public User(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender, Department department)
        {
            Username = username;
            Password = password;
            Name = name;
            LastName = lastName;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            Department = department;
        }
        #endregion

        #region Properties
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

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

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public DateTime DayOfBirth
        {
            get
            {
                return _dayOfBirth;
            }
            set
            {
                _dayOfBirth = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public Department Department
        {
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }

        public UserType UserType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        #endregion

        #region Methods
        public void CreateUser(SqlDataReader reader)
        {
            Id = Convert.ToInt32(reader["Id"].ToString());
            Username = reader["Username"].ToString();
            Password = reader["Password"].ToString();
            Name = reader["Name"].ToString();
            LastName = reader["LastName"].ToString();
            DayOfBirth = Convert.ToDateTime(reader["DayOfBirth"].ToString());
            if (Convert.ToBoolean(reader["IsGenderMale"].ToString()))
            {
                Gender = Gender.Male;
            }
            else if (Convert.ToBoolean(reader["IsGenderFemale"].ToString()))
            {
                Gender = Gender.Female;
            }
            else if (Convert.ToBoolean(reader["IsGenderUnknown"].ToString()))
            {
                Gender = Gender.Unknown;
            }

            Department department = new Department();
            department.CreateDepartment(reader);

            Department = department;

            switch (Convert.ToInt32(reader["UserTypeId"].ToString()))
            {
                case 1: UserType = UserType.Administrator;
                    break;
                case 2: UserType = UserType.Employee;
                    break;
                case 3: UserType = UserType.Manager;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
        #endregion
    }
}
