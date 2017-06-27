using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Zesium.Project.CompanySystem.Models.Services
{
    [Serializable]
    public static class InputServices
    {
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
    }
}
