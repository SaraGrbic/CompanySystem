using System;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class User
    {
        #region Fields
        private string _username;
        private string _password;
        private string _name;
        private string _lastname;
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

        public User(string username, string password, string name, string lastname, DateTime dayOfBirth, Gender gender, int id, Department department)
        {
            Username = username;
            Password = password;
            Name = name;
            Lastname = lastname;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            Id = id;
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

        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
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
    }
}
