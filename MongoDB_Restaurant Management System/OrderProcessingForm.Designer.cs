namespace MongoDB_Restaurant_Management_System
{
    partial class OrderProcessingForm
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // lblTitle
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTitle.Size = new System.Drawing.Size(660, 30);
            this.lblTitle.Text = "Order Processing";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // lblMenu
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMenu.Location = new System.Drawing.Point(12, 50);
            this.lblMenu.Size = new System.Drawing.Size(100, 20);
            this.lblMenu.Text = "Menu Items:";
            // dgvMenu
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(12, 73);
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(400, 220);
            // lblQty
            this.lblQty.Location = new System.Drawing.Point(12, 305);
            this.lblQty.Size = new System.Drawing.Size(70, 23);
            this.lblQty.Text = "Quantity:";
            // nudQuantity
            this.nudQuantity.Location = new System.Drawing.Point(85, 305);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 20;
            this.nudQuantity.Value = 1;
            this.nudQuantity.Size = new System.Drawing.Size(60, 23);
            // btnAddToOrder
            this.btnAddToOrder.Location = new System.Drawing.Point(160, 303);
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 28);
            this.btnAddToOrder.Text = "Add to Order";
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // lblOrder
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrder.Location = new System.Drawing.Point(430, 50);
            this.lblOrder.Size = new System.Drawing.Size(120, 20);
            this.lblOrder.Text = "Current Order:";
            // lstOrder
            this.lstOrder.Location = new System.Drawing.Point(430, 73);
            this.lstOrder.Size = new System.Drawing.Size(240, 220);
            // lblUserId
            this.lblUserId.Location = new System.Drawing.Point(430, 305);
            this.lblUserId.Size = new System.Drawing.Size(60, 23);
            this.lblUserId.Text = "User ID:";
            // txtUserId
            this.txtUserId.Location = new System.Drawing.Point(495, 305);
            this.txtUserId.Size = new System.Drawing.Size(175, 23);
            // btnPlaceOrder
            this.btnPlaceOrder.Location = new System.Drawing.Point(430, 345);
            this.btnPlaceOrder.Size = new System.Drawing.Size(120, 30);
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // btnClear
            this.btnClear.Location = new System.Drawing.Point(560, 345);
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // OrderProcessingForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnClear);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Processing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClear;
    }
}
