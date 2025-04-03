namespace StudentManagementSystem
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.txtBrgy = new System.Windows.Forms.TextBox();
            this.txtMunicipality = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtBirthdate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGuardianFirstName = new System.Windows.Forms.TextBox();
            this.txtGuardianLastName = new System.Windows.Forms.TextBox();
            this.txtHobbies = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Set up all TextBoxes as ReadOnly
            this.txtStudentID.ReadOnly = true;
            this.txtFirstName.ReadOnly = true;
            this.txtLastName.ReadOnly = true;
            this.txtMiddleName.ReadOnly = true;
            this.txtHouseNo.ReadOnly = true;
            this.txtBrgy.ReadOnly = true;
            this.txtMunicipality.ReadOnly = true;
            this.txtProvince.ReadOnly = true;
            this.txtRegion.ReadOnly = true;
            this.txtCountry.ReadOnly = true;
            this.txtBirthdate.ReadOnly = true;
            this.txtAge.ReadOnly = true;
            this.txtContact.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.txtGuardianFirstName.ReadOnly = true;
            this.txtGuardianLastName.ReadOnly = true;
            this.txtHobbies.ReadOnly = true;
            this.txtNickname.ReadOnly = true;
            this.txtCourse.ReadOnly = true;
            this.txtYear.ReadOnly = true;

            // Position controls
            int leftMargin = 150;
            int topMargin = 20;
            int spacing = 30;
            int currentTop = topMargin;

            // Student ID
            this.AddFormField("Student ID:", this.txtStudentID, ref currentTop);
            this.AddFormField("First Name:", this.txtFirstName, ref currentTop);
            this.AddFormField("Last Name:", this.txtLastName, ref currentTop);
            this.AddFormField("Middle Name:", this.txtMiddleName, ref currentTop);
            this.AddFormField("House No:", this.txtHouseNo, ref currentTop);
            this.AddFormField("Barangay:", this.txtBrgy, ref currentTop);
            this.AddFormField("Municipality:", this.txtMunicipality, ref currentTop);
            this.AddFormField("Province:", this.txtProvince, ref currentTop);
            this.AddFormField("Region:", this.txtRegion, ref currentTop);
            this.AddFormField("Country:", this.txtCountry, ref currentTop);
            this.AddFormField("Birthdate:", this.txtBirthdate, ref currentTop);
            this.AddFormField("Age:", this.txtAge, ref currentTop);
            this.AddFormField("Contact:", this.txtContact, ref currentTop);
            this.AddFormField("Email:", this.txtEmail, ref currentTop);
            this.AddFormField("Guardian First Name:", this.txtGuardianFirstName, ref currentTop);
            this.AddFormField("Guardian Last Name:", this.txtGuardianLastName, ref currentTop);
            this.AddFormField("Hobbies:", this.txtHobbies, ref currentTop);
            this.AddFormField("Nickname:", this.txtNickname, ref currentTop);
            this.AddFormField("Course:", this.txtCourse, ref currentTop);
            this.AddFormField("Year Level:", this.txtYear, ref currentTop);

            // Close button
            this.btnClose.Location = new System.Drawing.Point(leftMargin + 200, currentTop + spacing);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, currentTop + spacing * 2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StudentPage_Individual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void AddFormField(string labelText, System.Windows.Forms.TextBox textBox, ref int currentTop)
        {
            int leftMargin = 150;
            int spacing = 30;

            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(20, currentTop + 3);
            label.Size = new System.Drawing.Size(100, 13);
            label.Text = labelText;
            this.Controls.Add(label);

            textBox.Location = new System.Drawing.Point(leftMargin, currentTop);
            textBox.Size = new System.Drawing.Size(400, 20);
            this.Controls.Add(textBox);

            currentTop += spacing;
        }

        protected System.Windows.Forms.TextBox txtStudentID;
        protected System.Windows.Forms.TextBox txtFirstName;
        protected System.Windows.Forms.TextBox txtLastName;
        protected System.Windows.Forms.TextBox txtMiddleName;
        protected System.Windows.Forms.TextBox txtHouseNo;
        protected System.Windows.Forms.TextBox txtBrgy;
        protected System.Windows.Forms.TextBox txtMunicipality;
        protected System.Windows.Forms.TextBox txtProvince;
        protected System.Windows.Forms.TextBox txtRegion;
        protected System.Windows.Forms.TextBox txtCountry;
        protected System.Windows.Forms.TextBox txtBirthdate;
        protected System.Windows.Forms.TextBox txtAge;
        protected System.Windows.Forms.TextBox txtContact;
        protected System.Windows.Forms.TextBox txtEmail;
        protected System.Windows.Forms.TextBox txtGuardianFirstName;
        protected System.Windows.Forms.TextBox txtGuardianLastName;
        protected System.Windows.Forms.TextBox txtHobbies;
        protected System.Windows.Forms.TextBox txtNickname;
        protected System.Windows.Forms.TextBox txtCourse;
        protected System.Windows.Forms.TextBox txtYear;
        protected System.Windows.Forms.Button btnClose;
    }
} 