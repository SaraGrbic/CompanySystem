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
            Username = "admin";
            Password = "admin";
            Name = "Admin";
            Lastname = "Almighty";
            //DateTime adminAlmightyBirthday = new DateTime(1900, 01, 01);
            DayOfBirth = new DateTime(1900, 01, 01);//adminAlmightyBirthday;
            Gender = Gender.Unknown;
            Id = 0;
            UserType = UserType.Administrator;
        }
        #endregion

        #region Properties
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Name} {Lastname}";
        }
        #endregion
    }
}
