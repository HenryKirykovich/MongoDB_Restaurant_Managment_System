namespace MongoDB_Restaurant_Management_System
{
    partial class Form1
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnMenuManagement = new System.Windows.Forms.Button();
            this.btnOrderProcessing = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnOrderTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(476, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Restaurant Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(50, 90);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 40);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(290, 90);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(160, 40);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnMenuManagement
            // 
            this.btnMenuManagement.Location = new System.Drawing.Point(50, 150);
            this.btnMenuManagement.Name = "btnMenuManagement";
            this.btnMenuManagement.Size = new System.Drawing.Size(160, 40);
            this.btnMenuManagement.TabIndex = 3;
            this.btnMenuManagement.Text = "Menu Management";
            this.btnMenuManagement.Click += new System.EventHandler(this.btnMenuManagement_Click);
            // 
            // btnOrderProcessing
            // 
            this.btnOrderProcessing.Location = new System.Drawing.Point(290, 150);
            this.btnOrderProcessing.Name = "btnOrderProcessing";
            this.btnOrderProcessing.Size = new System.Drawing.Size(160, 40);
            this.btnOrderProcessing.TabIndex = 4;
            this.btnOrderProcessing.Text = "Order Processing";
            this.btnOrderProcessing.Click += new System.EventHandler(this.btnOrderProcessing_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(50, 210);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(160, 40);
            this.btnReservations.TabIndex = 5;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(290, 210);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(160, 40);
            this.btnFeedback.TabIndex = 6;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnOrderTracking
            // 
            this.btnOrderTracking.Location = new System.Drawing.Point(50, 270);
            this.btnOrderTracking.Name = "btnOrderTracking";
            this.btnOrderTracking.Size = new System.Drawing.Size(160, 40);
            this.btnOrderTracking.TabIndex = 7;
            this.btnOrderTracking.Text = "Order Tracking";
            this.btnOrderTracking.Click += new System.EventHandler(this.btnOrderTracking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnMenuManagement);
            this.Controls.Add(this.btnOrderProcessing);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnOrderTracking);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnMenuManagement;
        private System.Windows.Forms.Button btnOrderProcessing;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnOrderTracking;
    }
}

