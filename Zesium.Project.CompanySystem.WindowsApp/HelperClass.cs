using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.DAL.Context;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    static class companyService
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();

      
    }
}
