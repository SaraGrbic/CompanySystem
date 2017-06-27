using System;

namespace Zesium.Project.CompanySystem.Models
{
    [Serializable]
    public class Administrator : User
    {
        #region Fields
        #endregion

        #region Constructors
        public Administrator()
        {
            
        }

        public Administrator(int id, string username, string password, string name, string lastname, DateTime dayOfBirth, Gender gender)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            LastName = lastname;
            DayOfBirth = dayOfBirth;
            Gender = gender;
            Department = Company.Instance.Departments[0];
            UserType = UserType.Administrator;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
        #endregion
    }
}
