using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityofSarre_Assignment2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void uiAdminLoginButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AdminForm af = new AdminForm(uiAdminComboBox.Text, this);
            af.Show();
        }

        private void uiLecturerLoginButton_Click(object sender, EventArgs e)
        {
            if (uiLecComboBox.Text == "Default")
            {
                //this.Hide();
                LecturerForm lf = new LecturerForm(uiLecComboBox.Text);
                lf.Show();
            }
            else if (uiLecComboBox.Text == "" || uiPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please select lecturer and enter password.");
                return;
            }
                try
            {
                foreach (Lecturer name in PublicAccess.mLecturer.Where(i => i.GetName() == uiLecComboBox.Text))
                {
                    if (name.GetPass() == uiPasswordTextBox.Text || uiLecComboBox.Text == "Default")
                    {
                        //this.Hide();
                        LecturerForm lf = new LecturerForm(uiLecComboBox.Text);
                        lf.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public void UpdateAdminCombo()
        {
            foreach (Admin name in PublicAccess.mAdmin)
            {
                uiAdminComboBox.Items.Add(name.GetName());
            }
        }

        public void UpdateLecturerCombo()
        {
            uiLecComboBox.Items.Clear();
            foreach (Lecturer name in PublicAccess.mLecturer)
            {
                uiLecComboBox.Items.Add(name.GetName());
            }
            uiLecComboBox.SelectedIndex = 0;
        }


    }
}

