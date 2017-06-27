using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zesium.Project.CompanySystem.Models;
using ProjectClass = Zesium.Project.CompanySystem.Models.Project;
using TaskClass = Zesium.Project.CompanySystem.Models.Task;

namespace Zesium.Project.CompanySystem.WindowsApp
{
    static class HelperClass
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString.ToString();

        #region Methods
        public static bool Login(string username, string password)
        {
            bool retVal = false;
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                User user = new User();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Login";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    user.CreateUser(result);
                    retVal = true;
                }

                sqlConn.Close();
                Company.Instance.CurrentUser = user;
            }

            return retVal;
        }

        public static List<Department> GetAllDepartments()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<Department> departments = new List<Department>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllDepartments";
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    Department department = new Department();
                    department.CreateDepartment(result);
                    departments.Add(department);
                }

                sqlConn.Close();
                return departments;
            }
        }

        public static List<User> GetEmployeeManagers(int employeeId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<User> users = new List<User>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmployeeManagers";
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    User user = new User();
                    user.CreateUser(result);
                    users.Add(user);
                }

                sqlConn.Close();
                return users;
            }
        }

        public static List<ProjectClass> GetAllProjectsFromManager(int id)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<ProjectClass> projects = new List<ProjectClass>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProjectsFromManager";
                cmd.Parameters.AddWithValue("@managerId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    ProjectClass project = new ProjectClass();
                    project.CreateProject(result);
                    projects.Add(project);
                }

                sqlConn.Close();
                return projects;
            }
        }

        public static List<ProjectClass> GetAllProjectsFromEmployee(int employeeId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<ProjectClass> projects = new List<ProjectClass>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllProjectsFromEmployee";
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    ProjectClass project = new ProjectClass();
                    project.CreateProject(result);
                    projects.Add(project);
                }

                sqlConn.Close();
                return projects;
            }
        }

        public static List<TaskClass> GetEmployeeTasksForSelectedProject(int employeeId, int projectId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<TaskClass> tasks = new List<TaskClass>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetEmployeeTasksForSelectedProject";
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    TaskClass task = new TaskClass();
                    task.CreateTask(result);
                    tasks.Add(task);
                }

                sqlConn.Close();
                return tasks;
            }
        }

        public static List<TaskClass> GetAllTasksForSelectedProject(int projectId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<TaskClass> tasks = new List<TaskClass>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllTasksForSelectedProject";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    TaskClass task = new TaskClass();
                    task.CreateTask(result);
                    tasks.Add(task);
                }

                sqlConn.Close();
                return tasks;
            }
        }

        public static List<TaskClass> GetAllTasksFromManager(int managerId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<TaskClass> tasks = new List<TaskClass>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllTasksFromManager";
                cmd.Parameters.AddWithValue("@managerId", managerId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    TaskClass task = new TaskClass();
                    task.CreateTask(result);
                    tasks.Add(task);
                }

                sqlConn.Close();
                return tasks;
            }
        }

        public static List<User> GetAllUsers()
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<User> users = new List<User>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllUsers";
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    User user = new User();
                    user.CreateUser(result);
                    users.Add(user);
                }

                sqlConn.Close();
                return users;
            }
        }

        public static List<User> GetAllEmployeesFromManagerDepartment(int departmentId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                List<User> users = new List<User>();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAllEmployeesFromManagerDepartment";
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                cmd.Connection = sqlConn;

                sqlConn.Open();

                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    User user = new User();
                    user.CreateUser(result);
                    users.Add(user);
                }

                sqlConn.Close();
                return users;
            }
        }

        public static void CreateAdmin(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateAdmin";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dayOfBirth", dayOfBirth);
                switch (gender)
                {
                    case Gender.Male:
                        cmd.Parameters.AddWithValue("@isGenderMale", 1);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Female:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 1);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Unknown:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 1);
                        break;
                }
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void AddNewDepartment(string name, string description)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateDepartment";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void AddNewProject(string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateProject";
                cmd.Parameters.AddWithValue("@name", projectName);
                cmd.Parameters.AddWithValue("@price", projectPrice);
                cmd.Parameters.AddWithValue("@startDate", projectStartDate);
                cmd.Parameters.AddWithValue("@endDate", projectEndDate);
                cmd.Parameters.AddWithValue("@description", projectDescription);
                cmd.Parameters.AddWithValue("@departmentId", Company.Instance.CurrentUser.Department.DepartmentId);
                cmd.Parameters.AddWithValue("@managerId", Company.Instance.CurrentUser.Id);
                if (DateTime.Now > projectEndDate)
                {
                    cmd.Parameters.AddWithValue("@isProjectDelayed", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@isProjectDelayed", 0);
                }
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void AddNewTask(string taskName, DateTime taskStartTime, DateTime taskEndTime, string taskDescription, int employeeId, int projectId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateTask";
                cmd.Parameters.AddWithValue("@name", taskName);
                cmd.Parameters.AddWithValue("@startTime", taskStartTime);
                cmd.Parameters.AddWithValue("@endTime", taskEndTime);
                cmd.Parameters.AddWithValue("@description", taskDescription);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@employeeId", employeeId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void AddNewUser(string username, string password, string name, string lastName, DateTime dayOfBirth, Gender gender, Department department)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                User user = new User(username, password, name, lastName, dayOfBirth, gender, department);
                Company.Instance.CurrentUser = user;
                Company.Instance.CurrentUser.UserType = UserType.Employee;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CreateUser";
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dayOfBirth", dayOfBirth);
                switch (gender)
                {
                    case Gender.Male:
                        cmd.Parameters.AddWithValue("@isGenderMale", 1);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Female:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 1);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Unknown:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 1);
                        break;
                }
                cmd.Parameters.AddWithValue("@departmentId", department.DepartmentId);
                cmd.Parameters.AddWithValue("@userTypeId", 2);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void EditDepartment(int id, string name, string description)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditDepartment";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@departmentId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void EditProject(int id, string name, int price, string description, ProjectState projectState)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditProject";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@description", description);
                switch (projectState)
                {
                    case ProjectState.New:
                        cmd.Parameters.AddWithValue("@projectStateId", 1);
                        break;
                    case ProjectState.InProgres:
                        cmd.Parameters.AddWithValue("@projectStateId", 2);
                        break;
                    case ProjectState.Finished:
                        cmd.Parameters.AddWithValue("@projectStateId", 3);
                        break;
                    case ProjectState.Canceled:
                        cmd.Parameters.AddWithValue("@projectStateId", 4);
                        break;
                }
                cmd.Parameters.AddWithValue("@projectId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void EditTask(int id, int esimatedTime, int remainingTime, TaskState taskState, string taskComment)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditTask";
                cmd.Parameters.AddWithValue("@estimatedTime", esimatedTime);
                cmd.Parameters.AddWithValue("@remainingTime", remainingTime);
                cmd.Parameters.AddWithValue("@taskComment", taskComment);
                switch (taskState)
                {
                    case TaskState.To_Do:
                        cmd.Parameters.AddWithValue("@taskStateId", 1);
                        break;
                    case TaskState.In_Progres:
                        cmd.Parameters.AddWithValue("@taskStateId", 2);
                        break;
                    case TaskState.Done:
                        cmd.Parameters.AddWithValue("@taskStateId", 3);
                        break;
                }
                cmd.Parameters.AddWithValue("@taskId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void EditUser(int id, string name, string lastName, DateTime dayOfBirth, Gender gender, Department department)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditUser";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@dayOfBirth", dayOfBirth);
                switch (gender)
                {
                    case Gender.Male:
                        cmd.Parameters.AddWithValue("@isGenderMale", 1);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Female:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 1);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 0);
                        break;
                    case Gender.Unknown:
                        cmd.Parameters.AddWithValue("@isGenderMale", 0);
                        cmd.Parameters.AddWithValue("@isGenderFemale", 0);
                        cmd.Parameters.AddWithValue("@isGenderUnknown", 1);
                        break;
                }
                cmd.Parameters.AddWithValue("@departmentId", department.DepartmentId);
                cmd.Parameters.AddWithValue("@userId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void PromoteEmployeeToManager(int id, Department department)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PromoteEmployeeToManager";
                cmd.Parameters.AddWithValue("@departmentId", department.DepartmentId);
                cmd.Parameters.AddWithValue("@userId", id);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();

            }
        }

        public static void UpdateProjectStateAfterCreatingTask(int projectId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProjectStateAfterCreatingTask";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void UpdateTaskWhenStateChangedToDone(int taskId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTask";
                cmd.Parameters.AddWithValue("@taskId", taskId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void UpdateTasksWhenProjectIsCanceled(int projectId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ProjectCancelation";
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void UpdateProjectsWhenDepartmentIsCanceled(int departmentId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProjectsWhenDepartmentIsCanceled";
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void UpdateTasksWhenDepartmentIsCanceled(int departmentId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateTasksWhenDepartmentIsCanceled";
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void UpdateUsersWhenDepartmentIsCanceled(int departmentId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUsersWhenDepartmentIsCanceled";
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }

        public static void DepartmentCancelation(int departmentId)
        {
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DepartmentCancelation";
                cmd.Parameters.AddWithValue("@departmentId", departmentId);
                cmd.Connection = sqlConn;

                sqlConn.Open();
                cmd.ExecuteReader();
                sqlConn.Close();
            }
        }
        #endregion

    }
}
