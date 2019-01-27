using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UniversityofSarre_Assignment2
{
    public class PublicAccess //Access for all forms
    {
        //Person Class
        public static List<Student> mStudent = new List<Student>();
        public static List<Lecturer> mLecturer = new List<Lecturer>();
        public static List<Admin> mAdmin = new List<Admin>();

        //Appointment Class
        public static List<Personal> mPersonal = new List<Personal>();
        public static List<Attendance> mAttendance = new List<Attendance>();
        public static List<Academic> mAcademic = new List<Academic>();
    
        //Display Reports Method
        public static void ReportSystem(TextBox displayText, ComboBox searchBy, TextBox namEma, ComboBox cname)
        {
            var allAppointments = mAttendance.Concat<Appointment>(mPersonal).Concat(mAcademic);
            displayText.Text = "Appointment Type \t\t" + "Name \t" + "With \t" + "Time \t" + "Date \n";
            string enteredID;
            switch (searchBy.Text)
            {
                case "Student":
                    enteredID = namEma.Text;
                    if (cname.Text == "Name")
                    {
                        foreach (Appointment name in allAppointments.Where(i => i.GetName() == enteredID))
                        {
                            appendTextDisplay(name, displayText);
                        }
                    }
                    else
                    {
                        foreach (Person ID in PublicAccess.mStudent.Where(i => i.GetEmail() == enteredID))
                        {
                            enteredID = ID.GetName();
                            foreach (Appointment name in allAppointments.Where(i => i.GetName() == enteredID))
                            {
                                appendTextDisplay(name, displayText);
                            }
                        }
                    }
                    break;

                case "Lecturer":
                    enteredID = cname.Text;
                    bool found = false;
                    foreach (Appointment ID in allAppointments.Where(i => i.GetWith() == enteredID))
                    {
                        if (DateTime.Today == ID.GetDate())
                        {
                            found = true;
                            appendTextDisplay(ID, displayText);
                        }
                        else if (found == false)
                        {
                            displayText.Text = "No appointments today for given lecturer";
                        }
                    }
                    break;

                case "Admin":
                    enteredID = cname.Text;
                    found = false;
                    foreach (Appointment ID in allAppointments) {
                    bool has = PublicAccess.mAttendance.Any(i => i.GetMadeBy() == enteredID);
                        if (has)
                        {
                            if (ID.GetDate() < DateTime.Today && ID.GetAttend() == false)
                            {
                                found = true;
                                appendTextDisplay(ID, displayText);
                            }
                        }
                        else if (has == false && found == false)
                        {
                            displayText.Text = "No appointments to show";
                        }
                    }
                    break;
            }
        }
        //Format string to Display
        private static void appendTextDisplay(Appointment name, TextBox displayText)
        {
            string formatString = String.Format("{0}\t\t{1}\t{2}\t{3}\t{4}\n", name.GetTy(), name.GetName(), name.GetWith(), name.GetTime().ToString("t"), name.GetDate().ToString("d"));
            displayText.AppendText(formatString.ToString());
        }

        //Form Changes Report Section Method
        public static void ReportDisplayChange(ComboBox searchBy, TextBox byNameEmail, ComboBox byName)
        {
            switch (searchBy.Text)
            {
                case "Student":
                    byNameEmail.Visible = true;
                    byName.Items.Clear();
                    byName.Items.Add("Name");
                    byName.Items.Add("Email");
                    byName.SelectedIndex = 0;
                    break;

                case "Lecturer":
                    byNameEmail.Visible = false;
                    byName.Items.Clear();
                    byName.Text = "";
                    foreach (Lecturer l in PublicAccess.mLecturer)
                    {
                        byName.Items.Add(l.GetName());
                    }
                    if (byName.Items.Count > 0)
                    {
                        byName.SelectedIndex = 0;
                    }
                    break;

                case "Admin":
                    byNameEmail.Visible = false;
                    byName.Items.Clear();
                    byName.Text = "";
                    if (byName.Items.Count == 0)
                    {
                        byName.Items.Add("Default");
                    }
                    foreach (Admin a in PublicAccess.mAdmin)
                    {
                        byName.Items.Add(a.GetName());
                    }
                    if (byName.Items.Count > 0)
                    {
                        byName.SelectedIndex = 0;
                    }
                    break;
            }
        }
    }
}