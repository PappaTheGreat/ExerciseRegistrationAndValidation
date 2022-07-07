
namespace ExerciseRegistrationAndValidation
{
    partial class Form2
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
            this.SignIn = new System.Windows.Forms.Label();
            this.EmailSignIn = new System.Windows.Forms.Label();
            this.PasswordSignIn = new System.Windows.Forms.Label();
            this.TxtEmailSignIn = new System.Windows.Forms.TextBox();
            this.TxtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.AutoSize = true;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.SignIn.Location = new System.Drawing.Point(68, 23);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(582, 41);
            this.SignIn.TabIndex = 0;
            this.SignIn.Text = "If you are a registered user then Sign In ";
            // 
            // EmailSignIn
            // 
            this.EmailSignIn.AutoSize = true;
            this.EmailSignIn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailSignIn.Location = new System.Drawing.Point(147, 149);
            this.EmailSignIn.Name = "EmailSignIn";
            this.EmailSignIn.Size = new System.Drawing.Size(97, 36);
            this.EmailSignIn.TabIndex = 1;
            this.EmailSignIn.Text = "EmailId";
            // 
            // PasswordSignIn
            // 
            this.PasswordSignIn.AutoSize = true;
            this.PasswordSignIn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordSignIn.Location = new System.Drawing.Point(147, 249);
            this.PasswordSignIn.Name = "PasswordSignIn";
            this.PasswordSignIn.Size = new System.Drawing.Size(122, 36);
            this.PasswordSignIn.TabIndex = 2;
            this.PasswordSignIn.Text = "Password";
            // 
            // TxtEmailSignIn
            // 
            this.TxtEmailSignIn.Location = new System.Drawing.Point(343, 149);
            this.TxtEmailSignIn.Name = "TxtEmailSignIn";
            this.TxtEmailSignIn.Size = new System.Drawing.Size(245, 31);
            this.TxtEmailSignIn.TabIndex = 3;
            // 
            // TxtPasswordSignIn
            // 
            this.TxtPasswordSignIn.Location = new System.Drawing.Point(343, 249);
            this.TxtPasswordSignIn.Name = "TxtPasswordSignIn";
            this.TxtPasswordSignIn.Size = new System.Drawing.Size(245, 31);
            this.TxtPasswordSignIn.TabIndex = 4;
            this.TxtPasswordSignIn.UseSystemPasswordChar = true;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.Lime;
            this.SignInBtn.Location = new System.Drawing.Point(147, 363);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(112, 34);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.TxtPasswordSignIn);
            this.Controls.Add(this.TxtEmailSignIn);
            this.Controls.Add(this.PasswordSignIn);
            this.Controls.Add(this.EmailSignIn);
            this.Controls.Add(this.SignIn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignIn;
        private System.Windows.Forms.Label EmailSignIn;
        private System.Windows.Forms.Label PasswordSignIn;
        private System.Windows.Forms.TextBox TxtEmailSignIn;
        private System.Windows.Forms.TextBox TxtPasswordSignIn;
        private System.Windows.Forms.Button SignInBtn;
    }
}