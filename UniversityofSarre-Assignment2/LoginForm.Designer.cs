namespace UniversityofSarre_Assignment2
{
    partial class LoginForm
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
            this.uiLecturerLoginButton = new System.Windows.Forms.Button();
            this.uiAdminLoginButton = new System.Windows.Forms.Button();
            this.uiLecComboBox = new System.Windows.Forms.ComboBox();
            this.uiAdminComboBox = new System.Windows.Forms.ComboBox();
            this.uiLecLabel = new System.Windows.Forms.Label();
            this.uiAdminLabel = new System.Windows.Forms.Label();
            this.uiLoginLabel = new System.Windows.Forms.Label();
            this.uiPasswordTextBox = new System.Windows.Forms.TextBox();
            this.uiPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiLecturerLoginButton
            // 
            this.uiLecturerLoginButton.Location = new System.Drawing.Point(17, 129);
            this.uiLecturerLoginButton.Name = "uiLecturerLoginButton";
            this.uiLecturerLoginButton.Size = new System.Drawing.Size(101, 22);
            this.uiLecturerLoginButton.TabIndex = 2;
            this.uiLecturerLoginButton.Text = "Lecturer Login";
            this.uiLecturerLoginButton.UseVisualStyleBackColor = true;
            this.uiLecturerLoginButton.Click += new System.EventHandler(this.uiLecturerLoginButton_Click);
            // 
            // uiAdminLoginButton
            // 
            this.uiAdminLoginButton.Location = new System.Drawing.Point(186, 90);
            this.uiAdminLoginButton.Name = "uiAdminLoginButton";
            this.uiAdminLoginButton.Size = new System.Drawing.Size(101, 22);
            this.uiAdminLoginButton.TabIndex = 4;
            this.uiAdminLoginButton.Text = "Admin Login";
            this.uiAdminLoginButton.UseVisualStyleBackColor = true;
            this.uiAdminLoginButton.Click += new System.EventHandler(this.uiAdminLoginButton_Click);
            // 
            // uiLecComboBox
            // 
            this.uiLecComboBox.FormattingEnabled = true;
            this.uiLecComboBox.Location = new System.Drawing.Point(17, 63);
            this.uiLecComboBox.Name = "uiLecComboBox";
            this.uiLecComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiLecComboBox.TabIndex = 0;
            this.uiLecComboBox.Text = "Default";
            // 
            // uiAdminComboBox
            // 
            this.uiAdminComboBox.FormattingEnabled = true;
            this.uiAdminComboBox.Items.AddRange(new object[] {
            "Default"});
            this.uiAdminComboBox.Location = new System.Drawing.Point(186, 63);
            this.uiAdminComboBox.Name = "uiAdminComboBox";
            this.uiAdminComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiAdminComboBox.TabIndex = 3;
            this.uiAdminComboBox.Text = "Default";
            // 
            // uiLecLabel
            // 
            this.uiLecLabel.AutoSize = true;
            this.uiLecLabel.Location = new System.Drawing.Point(14, 47);
            this.uiLecLabel.Name = "uiLecLabel";
            this.uiLecLabel.Size = new System.Drawing.Size(79, 13);
            this.uiLecLabel.TabIndex = 6;
            this.uiLecLabel.Text = "Select Lecturer";
            // 
            // uiAdminLabel
            // 
            this.uiAdminLabel.AutoSize = true;
            this.uiAdminLabel.Location = new System.Drawing.Point(183, 47);
            this.uiAdminLabel.Name = "uiAdminLabel";
            this.uiAdminLabel.Size = new System.Drawing.Size(100, 13);
            this.uiAdminLabel.TabIndex = 8;
            this.uiAdminLabel.Text = "Select Administrator";
            // 
            // uiLoginLabel
            // 
            this.uiLoginLabel.AutoSize = true;
            this.uiLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLoginLabel.Location = new System.Drawing.Point(12, 9);
            this.uiLoginLabel.Name = "uiLoginLabel";
            this.uiLoginLabel.Size = new System.Drawing.Size(65, 25);
            this.uiLoginLabel.TabIndex = 9;
            this.uiLoginLabel.Text = "Login";
            // 
            // uiPasswordTextBox
            // 
            this.uiPasswordTextBox.Location = new System.Drawing.Point(17, 103);
            this.uiPasswordTextBox.Name = "uiPasswordTextBox";
            this.uiPasswordTextBox.Size = new System.Drawing.Size(121, 20);
            this.uiPasswordTextBox.TabIndex = 10;
            // 
            // uiPasswordLabel
            // 
            this.uiPasswordLabel.AutoSize = true;
            this.uiPasswordLabel.Location = new System.Drawing.Point(14, 87);
            this.uiPasswordLabel.Name = "uiPasswordLabel";
            this.uiPasswordLabel.Size = new System.Drawing.Size(81, 13);
            this.uiPasswordLabel.TabIndex = 11;
            this.uiPasswordLabel.Text = "Enter Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 175);
            this.Controls.Add(this.uiPasswordLabel);
            this.Controls.Add(this.uiPasswordTextBox);
            this.Controls.Add(this.uiLoginLabel);
            this.Controls.Add(this.uiAdminLabel);
            this.Controls.Add(this.uiLecLabel);
            this.Controls.Add(this.uiAdminComboBox);
            this.Controls.Add(this.uiLecComboBox);
            this.Controls.Add(this.uiAdminLoginButton);
            this.Controls.Add(this.uiLecturerLoginButton);
            this.Name = "LoginForm";
            this.Text = "University of Sarre - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiLecturerLoginButton;
        private System.Windows.Forms.Button uiAdminLoginButton;
        private System.Windows.Forms.ComboBox uiLecComboBox;
        private System.Windows.Forms.Label uiLecLabel;
        private System.Windows.Forms.Label uiAdminLabel;
        private System.Windows.Forms.Label uiLoginLabel;
        public System.Windows.Forms.ComboBox uiAdminComboBox;
        private System.Windows.Forms.TextBox uiPasswordTextBox;
        private System.Windows.Forms.Label uiPasswordLabel;
    }
}

