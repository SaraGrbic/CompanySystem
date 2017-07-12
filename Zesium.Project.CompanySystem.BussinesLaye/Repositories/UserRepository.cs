using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.BussinesLaye.Repositories
{
    public class UserRepository
    {
        public void Add(User user)
        {
            using (var db = new CompanyDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
                }
    }
}
