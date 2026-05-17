namespace MongoDB_Restaurant_Management_System
{
    partial class ReservationForm
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
            this.lblTable = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPeople = new System.Windows.Forms.Label();
            this.nudTable = new System.Windows.Forms.NumericUpDown();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.nudPeople = new System.Windows.Forms.NumericUpDown();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Size = new System.Drawing.Size(560, 30);
            this.lblTitle.Text = "Table Reservations";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblTable
            this.lblTable.Location = new System.Drawing.Point(12, 58);
            this.lblTable.Size = new System.Drawing.Size(90, 23);
            this.lblTable.Text = "Table Number:";
            // nudTable
            this.nudTable.Location = new System.Drawing.Point(100, 58);
            this.nudTable.Minimum = 1;
            this.nudTable.Maximum = 50;
            this.nudTable.Value = 1;
            this.nudTable.Size = new System.Drawing.Size(60, 23);
            // lblDate
            this.lblDate.Location = new System.Drawing.Point(12, 95);
            this.lblDate.Size = new System.Drawing.Size(90, 23);
            this.lblDate.Text = "Date & Time:";
            // dtpDate
            this.dtpDate.Location = new System.Drawing.Point(100, 95);
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Size = new System.Drawing.Size(180, 23);
            // lblPeople
            this.lblPeople.Location = new System.Drawing.Point(12, 132);
            this.lblPeople.Size = new System.Drawing.Size(90, 23);
            this.lblPeople.Text = "# of People:";
            // nudPeople
            this.nudPeople.Location = new System.Drawing.Point(100, 132);
            this.nudPeople.Minimum = 1;
            this.nudPeople.Maximum = 20;
            this.nudPeople.Value = 1;
            this.nudPeople.Size = new System.Drawing.Size(60, 23);
            // btnReserve
            this.btnReserve.Location = new System.Drawing.Point(12, 173);
            this.btnReserve.Size = new System.Drawing.Size(130, 30);
            this.btnReserve.Text = "Make Reservation";
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(155, 173);
            this.btnCancel.Size = new System.Drawing.Size(130, 30);
            this.btnCancel.Text = "Cancel Reservation";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // dgvReservations
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.Location = new System.Drawing.Point(12, 218);
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(560, 200);
            // ReservationForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 433);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.nudTable);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblPeople);
            this.Controls.Add(this.nudPeople);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvReservations);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.nudTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPeople;
        private System.Windows.Forms.NumericUpDown nudTable;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown nudPeople;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvReservations;
    }
}
