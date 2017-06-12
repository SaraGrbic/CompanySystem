using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zesium.Project.CompanySystem.Models.Services
{
    [Serializable]
    public static class InputServices
    {
        public static bool SignInSuccessful(string username, string password)
        {
            foreach(User user in Company.Instance.Users.Values)
            {
                if (user.Username == username && user.Password == password)
                {
                    Company.Instance.CurrentUser = user;
                    return true;
                }
            }
            return false;
        }

        public static void CreateUser(string username, string password, string name, string lastname, DateTime dayOfBirth, Gender gender, Department department)
        {
            var keys = new List<int>();
            foreach (var item in Company.Instance.Users.Keys)
            {
                keys.Add(item);
            }

            var id = GenerateNewKey(keys);

            Employee newUser = new Employee(username, password, name, lastname, dayOfBirth, gender, id, department);
            Company.Instance.CurrentUser = newUser;
            Company.Instance.Users.Add(newUser.Id, newUser);
        }

        public static void CreateAdmin(string username, string password, string name, string lastname, DateTime dayOfBirth, Gender gender)
        {
            var keys = new List<int>();
            foreach (var item in Company.Instance.Users.Keys)
            {
                keys.Add(item);
            }

            var id = GenerateNewKey(keys);

            Administrator newAdmin = new Administrator(id, username, password, name, lastname, dayOfBirth, gender);
            Company.Instance.Users.Add(id, newAdmin);
            
        }

        public static void CreateProject(string projectName, int projectPrice, string projectDescription, DateTime projectStartDate, DateTime projectEndDate, Manager projectManager, Department department)
        {
            var keys = new List<int>();
            foreach (var item in Company.Instance.Projects.Keys)
            {
                keys.Add(item);
            }

            var id = GenerateNewKey(keys);

            var newProject = new Project(id, projectName, projectPrice, projectDescription, projectStartDate, projectEndDate, projectManager, department);
            projectManager.ManagerProjects.Add(id, newProject);
            Company.Instance.Projects.Add(id, newProject);
        }

        public static void CreateDepartment(string name, string description)
        {
            var keys = new List<int>();
            foreach (var item in Company.Instance.Departments.Keys)
            {
                keys.Add(item);
            }

            var id = GenerateNewKey(keys);

            var newDepartment = new Department(id, name, description);
            Company.Instance.Departments.Add(id, newDepartment);
        }

        public static void CreateTask(string taskName, DateTime taskStartTime, DateTime taskEndTime, string taskDescription, Employee taskEmployee, Project selectedProject)
        {
            var keys = new List<int>();
            foreach (var item in selectedProject.ProjectTasks.Keys)
            {
                keys.Add(item);
            }

            var id = GenerateNewKey(keys);

            var newTask = new Task(id, taskName, taskStartTime, taskEndTime, taskDescription, taskEmployee, selectedProject);
            selectedProject.ProjectTasks.Add(id, newTask);

            if (!taskEmployee.EmployeeProjects.ContainsKey(selectedProject.ProjectId))
            {
                taskEmployee.EmployeeProjects.Add(selectedProject.ProjectId, selectedProject);
            }
        }

        public static bool TextBoxError(TextBox textBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Focus();
                errorProvider.SetError(textBox, "Popunite polje");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        public static bool RichTextBoxError(RichTextBox richTextBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(richTextBox.Text))
            {
                richTextBox.Focus();
                errorProvider.SetError(richTextBox, "Popunite polje");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        public static bool ComboBoxError(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (string.IsNullOrWhiteSpace(comboBox.Text))
            {
                comboBox.Focus();
                errorProvider.SetError(comboBox, "Izbaberite neki od ponuđenih departmana");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        public static bool TextBoxIntError(TextBox textBox, ErrorProvider errorProvider)
        {
            int dummyOutput = -1;

            if (string.IsNullOrWhiteSpace(textBox.Text) || !int.TryParse(textBox.Text, out dummyOutput) || dummyOutput < 0)
            {
                textBox.Focus();
                errorProvider.SetError(textBox, "Unos nije validan");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        public static bool DateTimePickersError(DateTimePicker picker1, DateTimePicker picker2, ErrorProvider errorProvider)
        {
            if (picker1.Value > picker2.Value)
            {
                picker2.Focus();
                errorProvider.SetError(picker2, "Greska. Ponovite unos.");
                return false;
            }
            errorProvider.Clear();
            return true;
        }

        private static int GenerateNewKey(List<int> keys)
        {
            if (keys.Count == 0)
            {
                return 0;
            }
            else
            {
                int max = keys[0];

                foreach (var item in keys)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }

                return max + 1;
            }
        }
    }
}
