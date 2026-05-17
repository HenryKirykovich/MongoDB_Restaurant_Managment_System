namespace MongoDB_Restaurant_Management_System
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(60, 20);
            this.lblTitle.Size = new System.Drawing.Size(260, 30);
            this.lblTitle.Text = "Register";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblUsername
            this.lblUsername.Location = new System.Drawing.Point(30, 70);
            this.lblUsername.Size = new System.Drawing.Size(80, 23);
            this.lblUsername.Text = "Username:";
            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(120, 70);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            // lblPassword
            this.lblPassword.Location = new System.Drawing.Point(30, 110);
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.Text = "Password:";
            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(120, 110);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';
            // lblEmail
            this.lblEmail.Location = new System.Drawing.Point(30, 150);
            this.lblEmail.Size = new System.Drawing.Size(80, 23);
            this.lblEmail.Text = "Email:";
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(120, 150);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            // lblRole
            this.lblRole.Location = new System.Drawing.Point(30, 190);
            this.lblRole.Size = new System.Drawing.Size(80, 23);
            this.lblRole.Text = "Role:";
            // cmbRole
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Items.AddRange(new object[] { "customer", "staff" });
            this.cmbRole.Location = new System.Drawing.Point(120, 190);
            this.cmbRole.Size = new System.Drawing.Size(200, 23);
            this.cmbRole.SelectedIndex = 0;
            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(80, 240);
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 240);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // RegisterForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
    }
}
