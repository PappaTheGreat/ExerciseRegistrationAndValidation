
namespace ExerciseRegistrationAndValidation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtRegistration = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.EmailId = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtConPass = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.DTPBD = new System.Windows.Forms.DateTimePicker();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.RegisteredUserSignIn = new System.Windows.Forms.Label();
            this.RegisteredSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtRegistration
            // 
            this.TxtRegistration.AutoSize = true;
            this.TxtRegistration.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TxtRegistration.Location = new System.Drawing.Point(207, 9);
            this.TxtRegistration.Name = "TxtRegistration";
            this.TxtRegistration.Size = new System.Drawing.Size(191, 41);
            this.TxtRegistration.TabIndex = 0;
            this.TxtRegistration.Text = "Registration";
            this.TxtRegistration.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(82, 110);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(97, 25);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(82, 158);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 25);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(82, 211);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(69, 25);
            this.Gender.TabIndex = 3;
            this.Gender.Text = "Gender";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(82, 267);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(90, 25);
            this.BirthDate.TabIndex = 4;
            this.BirthDate.Text = "Birth Date";
            // 
            // EmailId
            // 
            this.EmailId.AutoSize = true;
            this.EmailId.Location = new System.Drawing.Point(82, 318);
            this.EmailId.Name = "EmailId";
            this.EmailId.Size = new System.Drawing.Size(75, 25);
            this.EmailId.TabIndex = 5;
            this.EmailId.Text = "Email Id";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(82, 373);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 6;
            this.Password.Text = "Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(82, 427);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(156, 25);
            this.ConfirmPassword.TabIndex = 7;
            this.ConfirmPassword.Text = "Confirm Password";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(297, 104);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(224, 31);
            this.TxtFirstName.TabIndex = 8;
            // 
            // TxtConPass
            // 
            this.TxtConPass.Location = new System.Drawing.Point(297, 424);
            this.TxtConPass.Name = "TxtConPass";
            this.TxtConPass.Size = new System.Drawing.Size(224, 31);
            this.TxtConPass.TabIndex = 9;
            this.TxtConPass.UseSystemPasswordChar = true;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(297, 370);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(224, 31);
            this.TxtPass.TabIndex = 10;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // TxtGender
            // 
            this.TxtGender.Location = new System.Drawing.Point(297, 208);
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(224, 31);
            this.TxtGender.TabIndex = 11;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(297, 155);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(224, 31);
            this.TxtLastName.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(297, 315);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(224, 31);
            this.TxtEmail.TabIndex = 13;
            // 
            // DTPBD
            // 
            this.DTPBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPBD.Location = new System.Drawing.Point(297, 262);
            this.DTPBD.Name = "DTPBD";
            this.DTPBD.Size = new System.Drawing.Size(224, 31);
            this.DTPBD.TabIndex = 14;
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.Color.Lime;
            this.SignupBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignupBtn.Location = new System.Drawing.Point(82, 484);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(112, 34);
            this.SignupBtn.TabIndex = 15;
            this.SignupBtn.Text = "Sign Up";
            this.SignupBtn.UseVisualStyleBackColor = false;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.Red;
            this.ResetBtn.Location = new System.Drawing.Point(409, 484);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(112, 34);
            this.ResetBtn.TabIndex = 16;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // RegisteredUserSignIn
            // 
            this.RegisteredUserSignIn.AutoSize = true;
            this.RegisteredUserSignIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisteredUserSignIn.Location = new System.Drawing.Point(12, 570);
            this.RegisteredUserSignIn.Name = "RegisteredUserSignIn";
            this.RegisteredUserSignIn.Size = new System.Drawing.Size(340, 30);
            this.RegisteredUserSignIn.TabIndex = 17;
            this.RegisteredUserSignIn.Text = "If you are a registered user then : ";
            // 
            // RegisteredSignIn
            // 
            this.RegisteredSignIn.BackColor = System.Drawing.Color.Lime;
            this.RegisteredSignIn.Location = new System.Drawing.Point(409, 569);
            this.RegisteredSignIn.Name = "RegisteredSignIn";
            this.RegisteredSignIn.Size = new System.Drawing.Size(112, 34);
            this.RegisteredSignIn.TabIndex = 18;
            this.RegisteredSignIn.Text = "Sign In";
            this.RegisteredSignIn.UseVisualStyleBackColor = false;
            this.RegisteredSignIn.Click += new System.EventHandler(this.RegisteredSignIn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(610, 615);
            this.Controls.Add(this.RegisteredSignIn);
            this.Controls.Add(this.RegisteredUserSignIn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.DTPBD);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtConPass);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.EmailId);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.TxtRegistration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtRegistration;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label EmailId;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtConPass;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.DateTimePicker DTPBD;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label RegisteredUserSignIn;
        private System.Windows.Forms.Button RegisteredSignIn;
    }
}

