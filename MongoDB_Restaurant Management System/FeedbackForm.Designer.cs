namespace MongoDB_Restaurant_Management_System
{
    partial class FeedbackForm
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
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Size = new System.Drawing.Size(560, 30);
            this.lblTitle.Text = "Customer Feedback";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblOrderId
            this.lblOrderId.Location = new System.Drawing.Point(12, 58);
            this.lblOrderId.Size = new System.Drawing.Size(70, 23);
            this.lblOrderId.Text = "Order ID:";
            // txtOrderId
            this.txtOrderId.Location = new System.Drawing.Point(90, 58);
            this.txtOrderId.Size = new System.Drawing.Size(200, 23);
            // lblRating
            this.lblRating.Location = new System.Drawing.Point(12, 95);
            this.lblRating.Size = new System.Drawing.Size(70, 23);
            this.lblRating.Text = "Rating (1-5):";
            // nudRating
            this.nudRating.Location = new System.Drawing.Point(90, 95);
            this.nudRating.Minimum = 1;
            this.nudRating.Maximum = 5;
            this.nudRating.Value = 5;
            this.nudRating.Size = new System.Drawing.Size(60, 23);
            // lblComment
            this.lblComment.Location = new System.Drawing.Point(12, 132);
            this.lblComment.Size = new System.Drawing.Size(70, 23);
            this.lblComment.Text = "Comment:";
            // txtComment
            this.txtComment.Location = new System.Drawing.Point(90, 132);
            this.txtComment.Multiline = true;
            this.txtComment.Size = new System.Drawing.Size(200, 60);
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(90, 208);
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.Text = "Submit Feedback";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // dgvFeedback
            this.dgvFeedback.AllowUserToAddRows = false;
            this.dgvFeedback.AllowUserToDeleteRows = false;
            this.dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedback.Location = new System.Drawing.Point(12, 253);
            this.dgvFeedback.ReadOnly = true;
            this.dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedback.Size = new System.Drawing.Size(560, 160);
            // FeedbackForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 430);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvFeedback);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feedback";
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvFeedback;
    }
}
