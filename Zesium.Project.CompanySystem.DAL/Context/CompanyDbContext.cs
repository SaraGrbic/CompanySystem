using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models;

namespace Zesium.Project.CompanySystem.DAL.Context
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(): base()
        {
            this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new CompanyDbInitializer());
        }


        public DbSet<Department> Departmants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectClass.Project> Projects { get; set; }
        public DbSet<ProjectClass.Task> Tasks { get; set; }
        //public DbSet<UserTypeNames> UserTypeNames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<ProjectClass.Project>()
                .HasMany<User>(p => p.Employees).WithMany(u => u.EmployeeProjects); 
            modelBuilder.Entity<ProjectClass.Project>()
                .HasRequired(m => m.Manager).WithMany(p => p.ManagerProjects).HasForeignKey(p => p.ProjectManagerId).WillCascadeOnDelete(false);
            modelBuilder.Entity<ProjectClass.Task>()
                .HasRequired(p => p.TasksProject)
                .WithMany(p => p.Tasks)
                .HasForeignKey(p => p.ProjectId);
            modelBuilder.Entity<Department>()
                .HasOptional(p => p.Manager)
                .WithMany(d => d.ManagerDepartmants)
                .HasForeignKey(u => u.ManagerId);
            modelBuilder.Entity<Department>()
                .HasMany(p => p.Emloyees)
                .WithOptional(p => p.Department)
                .HasForeignKey(u => u.DepartmentId);



            base.OnModelCreating(modelBuilder);
        }


    }
}
