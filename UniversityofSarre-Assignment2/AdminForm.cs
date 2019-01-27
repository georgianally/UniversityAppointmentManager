using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace UniversityofSarre_Assignment2
{
    public partial class AdminForm : Form
    {
        string currentUser;
        LoginForm parent;

        public AdminForm(string user, LoginForm parentIN)
        {
            InitializeComponent();
            parent = parentIN;
            currentUser = user;
            uiTimePicker.ShowUpDown = true;
            uiCurrentUserLabel.Text = "Current User: " + currentUser;
            UpdateLecCombo();
            UpdateStudCombo();
        }

        private void uiLogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //LoginForm lf = new LoginForm();
            // lf.Show();
        }

        private void uiTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (uiTypeComboBox.SelectedItem.ToString())
            {
                case "Student":
                    uiTutorDeptLabel.Text = "Personal Tutor:";
                    VisableFalse();
                    break;
                case "Lecturer":
                    uiTutorDeptLabel.Text = "Department:";
                    uiPassLabel.Visible = true;
                    uiAddPassTextbox.Visible = true;
                    break;
                case "Admin":
                    uiTutorDeptLabel.Text = "Department:";
                    VisableFalse();
                    break;
                default:
                    VisableFalse();
                    break;
            }
        }

        //Add Person
        private void uiAddPersonButton_Click(object sender, EventArgs e)
        {
            string firstName = uiFirstNameTextBox.Text;
            string lastName = uiLastNameTextBox.Text;

            switch (uiTypeComboBox.Text)
            {
                case "Student":
                    if (string.IsNullOrWhiteSpace(uiFirstNameTextBox.Text) || string.IsNullOrWhiteSpace(uiLastNameTextBox.Text) || string.IsNullOrWhiteSpace(uiTutorDeptTextBox.Text))
                    {
                        MessageBox.Show("Please fill in all avalible fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        string tutor = uiTutorDeptTextBox.Text;
                        PublicAccess.mStudent.Add(new Student(firstName, lastName, tutor, currentUser));
                        foreach (Student ID in PublicAccess.mStudent.Where(per => per.GetName() == uiFirstNameTextBox.Text))
                        {
                            uiShowEmailTextbox.Text = ID.GetEmail();
                            uiShowIDTextBox.Text = ID.GetID();
                        }
                        UpdateStudCombo();
                    }
                    break;

                case "Lecturer":
                    if (string.IsNullOrWhiteSpace(uiFirstNameTextBox.Text) || string.IsNullOrWhiteSpace(uiLastNameTextBox.Text) || string.IsNullOrWhiteSpace(uiTutorDeptTextBox.Text) || string.IsNullOrWhiteSpace(uiAddPassTextbox.Text))
                    {
                        MessageBox.Show("Please fill in all avalible fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        string dept = uiTutorDeptTextBox.Text;
                        string pass = uiAddPassTextbox.Text;
                        PublicAccess.mLecturer.Add(new Lecturer(firstName, lastName, dept, pass));
                        foreach (Lecturer ID in PublicAccess.mLecturer.Where(per => per.GetName() == uiFirstNameTextBox.Text))
                        {
                            uiShowEmailTextbox.Text = ID.GetEmail();
                        }
                        parent.UpdateLecturerCombo();
                        UpdateLecCombo();
                    }
                    break;

                case "Admin":
                    if (string.IsNullOrWhiteSpace(uiFirstNameTextBox.Text) || string.IsNullOrWhiteSpace(uiLastNameTextBox.Text) || string.IsNullOrWhiteSpace(uiTutorDeptTextBox.Text))
                    {
                        MessageBox.Show("Please fill in all avalible fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    else
                    {
                        string dept = uiTutorDeptTextBox.Text;
                        PublicAccess.mAdmin.Add(new Admin(firstName, lastName, dept));
                        foreach (Admin ID in PublicAccess.mAdmin.Where(per => per.GetName() == uiFirstNameTextBox.Text))
                        {
                            uiShowEmailTextbox.Text = ID.GetEmail();
                        }
                        parent.UpdateAdminCombo();
                    }
                 break;
            }
        }

        //Add Appointment
        private void uiAttendenceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uiLecturerComboBox.Text) || string.IsNullOrWhiteSpace(uiStudentComboBox.Text))
            {
                MessageBox.Show("Missing Student or Lecturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime date = uiDatePicker.Value.Date;
                DateTime time = uiTimePicker.Value;
                string lecturer = uiLecturerComboBox.Text;
                bool attend = uiAttendCheckbox.Checked;
                string name = uiStudentComboBox.Text;
                string rating = uiRatingComboBox.Text;
                string ty = "Attendence";
                PublicAccess.mAttendance.Add(new Attendance(date, time, lecturer, attend, name, ty, currentUser, rating));

                //Zero Attendence student's emails to txt file
                if (attend = false && rating == "Zero")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter("Remove.txt"))
                        {
                            foreach (Student ID in PublicAccess.mStudent.Where(per => per.GetName() == name))
                            {
                                sw.WriteLine(ID.GetEmail());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Writing to File");
                    }
                }
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

        //Form changing method
        private void VisableFalse()
        {
            uiPassLabel.Visible = false;
            uiAddPassTextbox.Visible = false;
        }

        //Update comboboxes methods
        private void UpdateStudCombo()
        {
            uiStudentComboBox.Items.Clear();
            foreach (Student s in PublicAccess.mStudent)
            {
                uiStudentComboBox.Items.Add(s.GetName());
            }
            if (uiStudentComboBox.Items.Count > 0)
            {
                uiStudentComboBox.SelectedIndex = 0;
            }
        }

        private void UpdateLecCombo()
        {
            uiLecturerComboBox.Items.Clear();
            foreach (Lecturer l in PublicAccess.mLecturer)
            {
                uiLecturerComboBox.Items.Add(l.GetName());
            }
            if (uiLecturerComboBox.Items.Count > 0)
            {
                uiLecturerComboBox.SelectedIndex = 0;
            }
        }
    }
}
