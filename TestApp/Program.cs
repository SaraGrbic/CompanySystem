using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.DAL.Context;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var ctx = new CompanyDbContext())
            {
                var r = ctx.Tasks.ToList();
                foreach(var res in r)
                {
                    Console.WriteLine("äsd");
                }
            }
        }
    }
}
