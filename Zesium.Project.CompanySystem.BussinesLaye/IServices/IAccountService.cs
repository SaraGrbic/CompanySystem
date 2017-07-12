using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.BussinesLaye.Iservices
{
    public interface IAccountService
    {
        User LoginWeb(string username, string password);
  
        List<User> GetAllUsers();
    
        void CreateAdmin(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender);
       
        void AddNewUser(string username, string password,string lastName, string name, DateTime dayOfBirth, Gender gender, UserType userType, int departmentId);

        void EditUser(int id, string name, string lastName, DateTime dayOfBirth, Gender gender, Department department);
    }
      
}
