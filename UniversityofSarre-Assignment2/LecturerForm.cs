using System;
using System.Windows.Forms;

namespace UniversityofSarre_Assignment2
{
    public partial class LecturerForm : Form
    {
        public LecturerForm(string user)
        {
            InitializeComponent();
            UpdateStudCombo();
            UpdateLecCombo();
            uiCurrentUserLabel.Text = "Current User: " + user;
        }

        private void uiLogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //LoginForm lf = new LoginForm();
            //lf.Show();
        }

        //Add Appointments
        private void uiAcademicButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uiAcLecturerComboBox.Text) || string.IsNullOrWhiteSpace(uiAcStudentComboBox.Text))
            {
                MessageBox.Show("Missing Student or Lecturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime date = uiAcDatePicker.Value.Date;
                DateTime time = uiAcTimePicker.Value;
                string lecturer = uiAcLecturerComboBox.Text;
                bool attend = uiAcAttCheckBox.Checked;
                string name = uiAcStudentComboBox.Text;
                string ty = "Academic";
                string note = uiAcNotesTextBox.Text;
                PublicAccess.mAcademic.Add(new Academic(date, time, lecturer, attend, name, ty, note));
            }
        }

        private void uiPersonalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uiPerStudentComboBox.Text))
            {
                MessageBox.Show("Missing Student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime date = uiPerDatePicker.Value.Date;
                DateTime time = uiPerTimePicker.Value;
                string lecturer = uiPerLecturerTextBox.Text;
                bool attend = uiPerAttCheckBox.Checked;
                string name = uiPerStudentComboBox.Text;
                string ty = "Personal";
                string note = uiPerNotesTextBox.Text;
                bool confi = uiPerConfiCheckBox.Checked;
                PublicAccess.mPersonal.Add(new Personal(date, time, lecturer, attend, name, ty, note, confi));
            }
        }

        //Display Appointments Form Changes
        private void uiSearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PublicAccess.ReportDisplayChange(uiSearchByComboBox, uiNamEmaTextBox, uiNameComboBox);
        }

        //Display Appointments
        private void uiAppSearchButton_Click(object sender, EventArgs e)
        {
            PublicAccess.ReportSystem(uiDisplayTextBox, uiSearchByComboBox, uiNamEmaTextBox, uiNameComboBox);
        }

        //Put in accessobjects
        private void UpdateStudCombo()
        {
            foreach (Student s in PublicAccess.mStudent)
            {
                uiAcStudentComboBox.Items.Add(s.GetName());
                uiPerStudentComboBox.Items.Add(s.GetName());
            }
            if (uiAcStudentComboBox.Items.Count > 0)
            {
                uiAcStudentComboBox.SelectedIndex = 0;
                uiPerStudentComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateLecCombo()
        {
            foreach (Lecturer l in PublicAccess.mLecturer)
            {
                uiAcLecturerComboBox.Items.Add(l.GetName());
            }
            if (uiAcLecturerComboBox.Items.Count > 0)
            {
                uiAcLecturerComboBox.SelectedIndex = 0;
            }
        }

        private void uiPerStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Student ID in PublicAccess.mStudent)
            {
                if (ID.GetName() == uiPerStudentComboBox.Text)
                {
                    uiPerLecturerTextBox.Text = ID.GetTutor();
                }
            }
        }
    }
}

