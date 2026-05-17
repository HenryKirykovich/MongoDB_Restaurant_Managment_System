namespace MongoDB_Restaurant_Management_System
{
    partial class OrderTrackingForm
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
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnAdvanceStatus = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Size = new System.Drawing.Size(660, 30);
            this.lblTitle.Text = "Real-Time Order Tracking";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblHint
            this.lblHint.Location = new System.Drawing.Point(12, 48);
            this.lblHint.Size = new System.Drawing.Size(500, 20);
            this.lblHint.Text = "Select an order and click Advance Status to move: Placed → In Kitchen → Ready to Serve → Served";
            // dgvOrders
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(12, 75);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(660, 320);
            // btnAdvanceStatus
            this.btnAdvanceStatus.Location = new System.Drawing.Point(12, 410);
            this.btnAdvanceStatus.Size = new System.Drawing.Size(150, 35);
            this.btnAdvanceStatus.Text = "Advance Status";
            this.btnAdvanceStatus.Click += new System.EventHandler(this.btnAdvanceStatus_Click);
            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(175, 410);
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // OrderTrackingForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnAdvanceStatus);
            this.Controls.Add(this.btnRefresh);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnAdvanceStatus;
        private System.Windows.Forms.Button btnRefresh;
    }
}
