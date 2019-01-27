namespace UniversityofSarre_Assignment2
{
    partial class LecturerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLogOutButton = new System.Windows.Forms.Button();
            this.uiNamEmaTextBox = new System.Windows.Forms.TextBox();
            this.uiAppSearchButton = new System.Windows.Forms.Button();
            this.uiNameComboBox = new System.Windows.Forms.ComboBox();
            this.uiSearchByComboBox = new System.Windows.Forms.ComboBox();
            this.uiSearchByLabel = new System.Windows.Forms.Label();
            this.uiDisplayTextBox = new System.Windows.Forms.TextBox();
            this.uiPerStudentComboBox = new System.Windows.Forms.ComboBox();
            this.uiCurrentUserLabel = new System.Windows.Forms.Label();
            this.uiAppointmentLabel = new System.Windows.Forms.Label();
            this.uiPersonalButton = new System.Windows.Forms.Button();
            this.uiPerAttCheckBox = new System.Windows.Forms.CheckBox();
            this.uiPerTimeLabel = new System.Windows.Forms.Label();
            this.uiPerDateLabel = new System.Windows.Forms.Label();
            this.uiPerTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiPerDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiPerLecLabel = new System.Windows.Forms.Label();
            this.uiPerNameLabel = new System.Windows.Forms.Label();
            this.uiAttendenceLabel = new System.Windows.Forms.Label();
            this.uiLogOutLabel = new System.Windows.Forms.Label();
            this.uiNotesLabel = new System.Windows.Forms.Label();
            this.uiAcLecturerComboBox = new System.Windows.Forms.ComboBox();
            this.uiAcStudentComboBox = new System.Windows.Forms.ComboBox();
            this.uiAcademicButton = new System.Windows.Forms.Button();
            this.uiAcAttCheckBox = new System.Windows.Forms.CheckBox();
            this.uiAcTimeLabel = new System.Windows.Forms.Label();
            this.uiAcDateLabel = new System.Windows.Forms.Label();
            this.uiAcTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiAcDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiAcLecLabel = new System.Windows.Forms.Label();
            this.uiAcNameLabel = new System.Windows.Forms.Label();
            this.uiAcademicLabel = new System.Windows.Forms.Label();
            this.uiPerNotesLabel = new System.Windows.Forms.Label();
            this.uiAcNotesTextBox = new System.Windows.Forms.RichTextBox();
            this.uiPerNotesTextBox = new System.Windows.Forms.RichTextBox();
            this.uiPerConfiCheckBox = new System.Windows.Forms.CheckBox();
            this.uiAcademicAppGroupBox = new System.Windows.Forms.GroupBox();
            this.uiPersonalAppGroupBox = new System.Windows.Forms.GroupBox();
            this.uiPerLecturerTextBox = new System.Windows.Forms.TextBox();
            this.uiPersonalAppGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLogOutButton
            // 
            this.uiLogOutButton.Location = new System.Drawing.Point(12, 12);
            this.uiLogOutButton.Name = "uiLogOutButton";
            this.uiLogOutButton.Size = new System.Drawing.Size(75, 23);
            this.uiLogOutButton.TabIndex = 1;
            this.uiLogOutButton.Text = "Log Out";
            this.uiLogOutButton.UseVisualStyleBackColor = true;
            this.uiLogOutButton.Click += new System.EventHandler(this.uiLogOutButton_Click);
            // 
            // uiNamEmaTextBox
            // 
            this.uiNamEmaTextBox.Location = new System.Drawing.Point(331, 362);
            this.uiNamEmaTextBox.Name = "uiNamEmaTextBox";
            this.uiNamEmaTextBox.Size = new System.Drawing.Size(162, 20);
            this.uiNamEmaTextBox.TabIndex = 62;
            // 
            // uiAppSearchButton
            // 
            this.uiAppSearchButton.Location = new System.Drawing.Point(12, 384);
            this.uiAppSearchButton.Name = "uiAppSearchButton";
            this.uiAppSearchButton.Size = new System.Drawing.Size(75, 23);
            this.uiAppSearchButton.TabIndex = 63;
            this.uiAppSearchButton.Text = "Search";
            this.uiAppSearchButton.UseVisualStyleBackColor = true;
            this.uiAppSearchButton.Click += new System.EventHandler(this.uiAppSearchButton_Click);
            // 
            // uiNameComboBox
            // 
            this.uiNameComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiNameComboBox.FormattingEnabled = true;
            this.uiNameComboBox.Items.AddRange(new object[] {
            "Name",
            "Email"});
            this.uiNameComboBox.Location = new System.Drawing.Point(225, 361);
            this.uiNameComboBox.Name = "uiNameComboBox";
            this.uiNameComboBox.Size = new System.Drawing.Size(100, 21);
            this.uiNameComboBox.TabIndex = 61;
            this.uiNameComboBox.Text = "Name";
            // 
            // uiSearchByComboBox
            // 
            this.uiSearchByComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSearchByComboBox.FormattingEnabled = true;
            this.uiSearchByComboBox.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "Admin"});
            this.uiSearchByComboBox.Location = new System.Drawing.Point(96, 360);
            this.uiSearchByComboBox.Name = "uiSearchByComboBox";
            this.uiSearchByComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiSearchByComboBox.TabIndex = 59;
            this.uiSearchByComboBox.Text = "Student";
            this.uiSearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.uiSearchByComboBox_SelectedIndexChanged);
            // 
            // uiSearchByLabel
            // 
            this.uiSearchByLabel.AutoSize = true;
            this.uiSearchByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSearchByLabel.Location = new System.Drawing.Point(18, 361);
            this.uiSearchByLabel.Name = "uiSearchByLabel";
            this.uiSearchByLabel.Size = new System.Drawing.Size(73, 16);
            this.uiSearchByLabel.TabIndex = 71;
            this.uiSearchByLabel.Text = "Search By:";
            // 
            // uiDisplayTextBox
            // 
            this.uiDisplayTextBox.Location = new System.Drawing.Point(12, 413);
            this.uiDisplayTextBox.Multiline = true;
            this.uiDisplayTextBox.Name = "uiDisplayTextBox";
            this.uiDisplayTextBox.ReadOnly = true;
            this.uiDisplayTextBox.Size = new System.Drawing.Size(672, 205);
            this.uiDisplayTextBox.TabIndex = 64;
            // 
            // uiPerStudentComboBox
            // 
            this.uiPerStudentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiPerStudentComboBox.FormattingEnabled = true;
            this.uiPerStudentComboBox.Location = new System.Drawing.Point(96, 226);
            this.uiPerStudentComboBox.Name = "uiPerStudentComboBox";
            this.uiPerStudentComboBox.Size = new System.Drawing.Size(122, 21);
            this.uiPerStudentComboBox.TabIndex = 49;
            this.uiPerStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.uiPerStudentComboBox_SelectedIndexChanged);
            // 
            // uiCurrentUserLabel
            // 
            this.uiCurrentUserLabel.AutoSize = true;
            this.uiCurrentUserLabel.Location = new System.Drawing.Point(530, 17);
            this.uiCurrentUserLabel.Name = "uiCurrentUserLabel";
            this.uiCurrentUserLabel.Size = new System.Drawing.Size(69, 13);
            this.uiCurrentUserLabel.TabIndex = 69;
            this.uiCurrentUserLabel.Text = "Current User:";
            // 
            // uiAppointmentLabel
            // 
            this.uiAppointmentLabel.AutoSize = true;
            this.uiAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiAppointmentLabel.Location = new System.Drawing.Point(12, 328);
            this.uiAppointmentLabel.Name = "uiAppointmentLabel";
            this.uiAppointmentLabel.Size = new System.Drawing.Size(220, 25);
            this.uiAppointmentLabel.TabIndex = 67;
            this.uiAppointmentLabel.Text = "Display Appointments";
            // 
            // uiPersonalButton
            // 
            this.uiPersonalButton.Location = new System.Drawing.Point(12, 302);
            this.uiPersonalButton.Name = "uiPersonalButton";
            this.uiPersonalButton.Size = new System.Drawing.Size(97, 23);
            this.uiPersonalButton.TabIndex = 58;
            this.uiPersonalButton.Text = "Add Appointment";
            this.uiPersonalButton.UseVisualStyleBackColor = true;
            this.uiPersonalButton.Click += new System.EventHandler(this.uiPersonalButton_Click);
            // 
            // uiPerAttCheckBox
            // 
            this.uiPerAttCheckBox.AutoSize = true;
            this.uiPerAttCheckBox.Location = new System.Drawing.Point(277, 256);
            this.uiPerAttCheckBox.Name = "uiPerAttCheckBox";
            this.uiPerAttCheckBox.Size = new System.Drawing.Size(69, 17);
            this.uiPerAttCheckBox.TabIndex = 55;
            this.uiPerAttCheckBox.Text = "Attended";
            this.uiPerAttCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiPerTimeLabel
            // 
            this.uiPerTimeLabel.AutoSize = true;
            this.uiPerTimeLabel.Location = new System.Drawing.Point(383, 253);
            this.uiPerTimeLabel.Name = "uiPerTimeLabel";
            this.uiPerTimeLabel.Size = new System.Drawing.Size(95, 13);
            this.uiPerTimeLabel.TabIndex = 66;
            this.uiPerTimeLabel.Text = "Appointment Time:";
            // 
            // uiPerDateLabel
            // 
            this.uiPerDateLabel.AutoSize = true;
            this.uiPerDateLabel.Location = new System.Drawing.Point(383, 230);
            this.uiPerDateLabel.Name = "uiPerDateLabel";
            this.uiPerDateLabel.Size = new System.Drawing.Size(95, 13);
            this.uiPerDateLabel.TabIndex = 65;
            this.uiPerDateLabel.Text = "Appointment Date:";
            // 
            // uiPerTimePicker
            // 
            this.uiPerTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiPerTimePicker.Location = new System.Drawing.Point(484, 253);
            this.uiPerTimePicker.Name = "uiPerTimePicker";
            this.uiPerTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uiPerTimePicker.TabIndex = 57;
            // 
            // uiPerDatePicker
            // 
            this.uiPerDatePicker.Location = new System.Drawing.Point(484, 227);
            this.uiPerDatePicker.Name = "uiPerDatePicker";
            this.uiPerDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uiPerDatePicker.TabIndex = 52;
            // 
            // uiPerLecLabel
            // 
            this.uiPerLecLabel.AutoSize = true;
            this.uiPerLecLabel.Location = new System.Drawing.Point(222, 229);
            this.uiPerLecLabel.Name = "uiPerLecLabel";
            this.uiPerLecLabel.Size = new System.Drawing.Size(49, 13);
            this.uiPerLecLabel.TabIndex = 60;
            this.uiPerLecLabel.Text = "Lecturer:";
            // 
            // uiPerNameLabel
            // 
            this.uiPerNameLabel.AutoSize = true;
            this.uiPerNameLabel.Location = new System.Drawing.Point(16, 229);
            this.uiPerNameLabel.Name = "uiPerNameLabel";
            this.uiPerNameLabel.Size = new System.Drawing.Size(78, 13);
            this.uiPerNameLabel.TabIndex = 56;
            this.uiPerNameLabel.Text = "Student Name:";
            // 
            // uiAttendenceLabel
            // 
            this.uiAttendenceLabel.AutoSize = true;
            this.uiAttendenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiAttendenceLabel.Location = new System.Drawing.Point(12, 198);
            this.uiAttendenceLabel.Name = "uiAttendenceLabel";
            this.uiAttendenceLabel.Size = new System.Drawing.Size(223, 25);
            this.uiAttendenceLabel.TabIndex = 54;
            this.uiAttendenceLabel.Text = "Personal Appointment";
            // 
            // uiLogOutLabel
            // 
            this.uiLogOutLabel.AutoSize = true;
            this.uiLogOutLabel.Location = new System.Drawing.Point(93, 17);
            this.uiLogOutLabel.Name = "uiLogOutLabel";
            this.uiLogOutLabel.Size = new System.Drawing.Size(116, 13);
            this.uiLogOutLabel.TabIndex = 38;
            this.uiLogOutLabel.Text = "Log out to switch users";
            // 
            // uiNotesLabel
            // 
            this.uiNotesLabel.AutoSize = true;
            this.uiNotesLabel.Location = new System.Drawing.Point(16, 114);
            this.uiNotesLabel.Name = "uiNotesLabel";
            this.uiNotesLabel.Size = new System.Drawing.Size(38, 13);
            this.uiNotesLabel.TabIndex = 84;
            this.uiNotesLabel.Text = "Notes:";
            // 
            // uiAcLecturerComboBox
            // 
            this.uiAcLecturerComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiAcLecturerComboBox.FormattingEnabled = true;
            this.uiAcLecturerComboBox.Location = new System.Drawing.Point(277, 86);
            this.uiAcLecturerComboBox.Name = "uiAcLecturerComboBox";
            this.uiAcLecturerComboBox.Size = new System.Drawing.Size(100, 21);
            this.uiAcLecturerComboBox.TabIndex = 73;
            // 
            // uiAcStudentComboBox
            // 
            this.uiAcStudentComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiAcStudentComboBox.FormattingEnabled = true;
            this.uiAcStudentComboBox.Location = new System.Drawing.Point(96, 86);
            this.uiAcStudentComboBox.Name = "uiAcStudentComboBox";
            this.uiAcStudentComboBox.Size = new System.Drawing.Size(122, 21);
            this.uiAcStudentComboBox.TabIndex = 72;
            // 
            // uiAcademicButton
            // 
            this.uiAcademicButton.Location = new System.Drawing.Point(12, 172);
            this.uiAcademicButton.Name = "uiAcademicButton";
            this.uiAcademicButton.Size = new System.Drawing.Size(97, 23);
            this.uiAcademicButton.TabIndex = 80;
            this.uiAcademicButton.Text = "Add Appointment";
            this.uiAcademicButton.UseVisualStyleBackColor = true;
            this.uiAcademicButton.Click += new System.EventHandler(this.uiAcademicButton_Click);
            // 
            // uiAcAttCheckBox
            // 
            this.uiAcAttCheckBox.AutoSize = true;
            this.uiAcAttCheckBox.Location = new System.Drawing.Point(277, 118);
            this.uiAcAttCheckBox.Name = "uiAcAttCheckBox";
            this.uiAcAttCheckBox.Size = new System.Drawing.Size(69, 17);
            this.uiAcAttCheckBox.TabIndex = 77;
            this.uiAcAttCheckBox.Text = "Attended";
            this.uiAcAttCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiAcTimeLabel
            // 
            this.uiAcTimeLabel.AutoSize = true;
            this.uiAcTimeLabel.Location = new System.Drawing.Point(383, 113);
            this.uiAcTimeLabel.Name = "uiAcTimeLabel";
            this.uiAcTimeLabel.Size = new System.Drawing.Size(95, 13);
            this.uiAcTimeLabel.TabIndex = 83;
            this.uiAcTimeLabel.Text = "Appointment Time:";
            // 
            // uiAcDateLabel
            // 
            this.uiAcDateLabel.AutoSize = true;
            this.uiAcDateLabel.Location = new System.Drawing.Point(383, 90);
            this.uiAcDateLabel.Name = "uiAcDateLabel";
            this.uiAcDateLabel.Size = new System.Drawing.Size(95, 13);
            this.uiAcDateLabel.TabIndex = 82;
            this.uiAcDateLabel.Text = "Appointment Date:";
            // 
            // uiAcTimePicker
            // 
            this.uiAcTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uiAcTimePicker.Location = new System.Drawing.Point(484, 113);
            this.uiAcTimePicker.Name = "uiAcTimePicker";
            this.uiAcTimePicker.Size = new System.Drawing.Size(200, 20);
            this.uiAcTimePicker.TabIndex = 79;
            // 
            // uiAcDatePicker
            // 
            this.uiAcDatePicker.Location = new System.Drawing.Point(484, 87);
            this.uiAcDatePicker.Name = "uiAcDatePicker";
            this.uiAcDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uiAcDatePicker.TabIndex = 74;
            // 
            // uiAcLecLabel
            // 
            this.uiAcLecLabel.AutoSize = true;
            this.uiAcLecLabel.Location = new System.Drawing.Point(222, 89);
            this.uiAcLecLabel.Name = "uiAcLecLabel";
            this.uiAcLecLabel.Size = new System.Drawing.Size(49, 13);
            this.uiAcLecLabel.TabIndex = 81;
            this.uiAcLecLabel.Text = "Lecturer:";
            // 
            // uiAcNameLabel
            // 
            this.uiAcNameLabel.AutoSize = true;
            this.uiAcNameLabel.Location = new System.Drawing.Point(16, 89);
            this.uiAcNameLabel.Name = "uiAcNameLabel";
            this.uiAcNameLabel.Size = new System.Drawing.Size(78, 13);
            this.uiAcNameLabel.TabIndex = 78;
            this.uiAcNameLabel.Text = "Student Name:";
            // 
            // uiAcademicLabel
            // 
            this.uiAcademicLabel.AutoSize = true;
            this.uiAcademicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiAcademicLabel.Location = new System.Drawing.Point(12, 58);
            this.uiAcademicLabel.Name = "uiAcademicLabel";
            this.uiAcademicLabel.Size = new System.Drawing.Size(232, 25);
            this.uiAcademicLabel.TabIndex = 76;
            this.uiAcademicLabel.Text = "Academic Appointment";
            // 
            // uiPerNotesLabel
            // 
            this.uiPerNotesLabel.AutoSize = true;
            this.uiPerNotesLabel.Location = new System.Drawing.Point(18, 261);
            this.uiPerNotesLabel.Name = "uiPerNotesLabel";
            this.uiPerNotesLabel.Size = new System.Drawing.Size(38, 13);
            this.uiPerNotesLabel.TabIndex = 85;
            this.uiPerNotesLabel.Text = "Notes:";
            // 
            // uiAcNotesTextBox
            // 
            this.uiAcNotesTextBox.Location = new System.Drawing.Point(96, 116);
            this.uiAcNotesTextBox.Name = "uiAcNotesTextBox";
            this.uiAcNotesTextBox.Size = new System.Drawing.Size(164, 50);
            this.uiAcNotesTextBox.TabIndex = 86;
            this.uiAcNotesTextBox.Text = "";
            // 
            // uiPerNotesTextBox
            // 
            this.uiPerNotesTextBox.Location = new System.Drawing.Point(96, 256);
            this.uiPerNotesTextBox.Name = "uiPerNotesTextBox";
            this.uiPerNotesTextBox.Size = new System.Drawing.Size(164, 40);
            this.uiPerNotesTextBox.TabIndex = 87;
            this.uiPerNotesTextBox.Text = "";
            // 
            // uiPerConfiCheckBox
            // 
            this.uiPerConfiCheckBox.AutoSize = true;
            this.uiPerConfiCheckBox.Location = new System.Drawing.Point(277, 279);
            this.uiPerConfiCheckBox.Name = "uiPerConfiCheckBox";
            this.uiPerConfiCheckBox.Size = new System.Drawing.Size(81, 17);
            this.uiPerConfiCheckBox.TabIndex = 89;
            this.uiPerConfiCheckBox.Text = "Confidential";
            this.uiPerConfiCheckBox.UseVisualStyleBackColor = true;
            // 
            // uiAcademicAppGroupBox
            // 
            this.uiAcademicAppGroupBox.Location = new System.Drawing.Point(12, 66);
            this.uiAcademicAppGroupBox.Name = "uiAcademicAppGroupBox";
            this.uiAcademicAppGroupBox.Size = new System.Drawing.Size(683, 129);
            this.uiAcademicAppGroupBox.TabIndex = 90;
            this.uiAcademicAppGroupBox.TabStop = false;
            // 
            // uiPersonalAppGroupBox
            // 
            this.uiPersonalAppGroupBox.Controls.Add(this.uiPerLecturerTextBox);
            this.uiPersonalAppGroupBox.Location = new System.Drawing.Point(12, 201);
            this.uiPersonalAppGroupBox.Name = "uiPersonalAppGroupBox";
            this.uiPersonalAppGroupBox.Size = new System.Drawing.Size(683, 124);
            this.uiPersonalAppGroupBox.TabIndex = 91;
            this.uiPersonalAppGroupBox.TabStop = false;
            // 
            // uiPerLecturerTextBox
            // 
            this.uiPerLecturerTextBox.Location = new System.Drawing.Point(265, 25);
            this.uiPerLecturerTextBox.Name = "uiPerLecturerTextBox";
            this.uiPerLecturerTextBox.ReadOnly = true;
            this.uiPerLecturerTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiPerLecturerTextBox.TabIndex = 51;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 630);
            this.Controls.Add(this.uiPerConfiCheckBox);
            this.Controls.Add(this.uiPerNotesTextBox);
            this.Controls.Add(this.uiAcNotesTextBox);
            this.Controls.Add(this.uiPerNotesLabel);
            this.Controls.Add(this.uiNotesLabel);
            this.Controls.Add(this.uiAcLecturerComboBox);
            this.Controls.Add(this.uiAcStudentComboBox);
            this.Controls.Add(this.uiAcademicButton);
            this.Controls.Add(this.uiAcAttCheckBox);
            this.Controls.Add(this.uiAcTimeLabel);
            this.Controls.Add(this.uiAcDateLabel);
            this.Controls.Add(this.uiAcTimePicker);
            this.Controls.Add(this.uiAcDatePicker);
            this.Controls.Add(this.uiAcLecLabel);
            this.Controls.Add(this.uiAcNameLabel);
            this.Controls.Add(this.uiAcademicLabel);
            this.Controls.Add(this.uiNamEmaTextBox);
            this.Controls.Add(this.uiAppSearchButton);
            this.Controls.Add(this.uiNameComboBox);
            this.Controls.Add(this.uiSearchByComboBox);
            this.Controls.Add(this.uiSearchByLabel);
            this.Controls.Add(this.uiDisplayTextBox);
            this.Controls.Add(this.uiPerStudentComboBox);
            this.Controls.Add(this.uiCurrentUserLabel);
            this.Controls.Add(this.uiAppointmentLabel);
            this.Controls.Add(this.uiPersonalButton);
            this.Controls.Add(this.uiPerAttCheckBox);
            this.Controls.Add(this.uiPerTimeLabel);
            this.Controls.Add(this.uiPerDateLabel);
            this.Controls.Add(this.uiPerTimePicker);
            this.Controls.Add(this.uiPerDatePicker);
            this.Controls.Add(this.uiPerLecLabel);
            this.Controls.Add(this.uiPerNameLabel);
            this.Controls.Add(this.uiAttendenceLabel);
            this.Controls.Add(this.uiLogOutLabel);
            this.Controls.Add(this.uiLogOutButton);
            this.Controls.Add(this.uiAcademicAppGroupBox);
            this.Controls.Add(this.uiPersonalAppGroupBox);
            this.Name = "LecturerForm";
            this.Text = "LecturerForm";
            this.uiPersonalAppGroupBox.ResumeLayout(false);
            this.uiPersonalAppGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiLogOutButton;
        private System.Windows.Forms.TextBox uiNamEmaTextBox;
        private System.Windows.Forms.Button uiAppSearchButton;
        private System.Windows.Forms.ComboBox uiNameComboBox;
        private System.Windows.Forms.ComboBox uiSearchByComboBox;
        private System.Windows.Forms.Label uiSearchByLabel;
        private System.Windows.Forms.TextBox uiDisplayTextBox;
        private System.Windows.Forms.ComboBox uiPerStudentComboBox;
        private System.Windows.Forms.Label uiCurrentUserLabel;
        private System.Windows.Forms.Label uiAppointmentLabel;
        private System.Windows.Forms.Button uiPersonalButton;
        private System.Windows.Forms.CheckBox uiPerAttCheckBox;
        private System.Windows.Forms.Label uiPerTimeLabel;
        private System.Windows.Forms.Label uiPerDateLabel;
        private System.Windows.Forms.DateTimePicker uiPerTimePicker;
        private System.Windows.Forms.DateTimePicker uiPerDatePicker;
        private System.Windows.Forms.Label uiPerLecLabel;
        private System.Windows.Forms.Label uiPerNameLabel;
        private System.Windows.Forms.Label uiAttendenceLabel;
        private System.Windows.Forms.Label uiLogOutLabel;
        private System.Windows.Forms.Label uiNotesLabel;
        private System.Windows.Forms.ComboBox uiAcLecturerComboBox;
        private System.Windows.Forms.ComboBox uiAcStudentComboBox;
        private System.Windows.Forms.Button uiAcademicButton;
        private System.Windows.Forms.CheckBox uiAcAttCheckBox;
        private System.Windows.Forms.Label uiAcTimeLabel;
        private System.Windows.Forms.Label uiAcDateLabel;
        private System.Windows.Forms.DateTimePicker uiAcTimePicker;
        private System.Windows.Forms.DateTimePicker uiAcDatePicker;
        private System.Windows.Forms.Label uiAcLecLabel;
        private System.Windows.Forms.Label uiAcNameLabel;
        private System.Windows.Forms.Label uiAcademicLabel;
        private System.Windows.Forms.Label uiPerNotesLabel;
        private System.Windows.Forms.RichTextBox uiAcNotesTextBox;
        private System.Windows.Forms.RichTextBox uiPerNotesTextBox;
        private System.Windows.Forms.CheckBox uiPerConfiCheckBox;
        private System.Windows.Forms.GroupBox uiAcademicAppGroupBox;
        private System.Windows.Forms.GroupBox uiPersonalAppGroupBox;
        private System.Windows.Forms.TextBox uiPerLecturerTextBox;
    }
}