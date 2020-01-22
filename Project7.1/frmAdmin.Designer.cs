namespace Project7
{
    partial class frmAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRemaining = new System.Windows.Forms.GroupBox();
            this.lblUpperCount = new System.Windows.Forms.Label();
            this.lblUpperRem = new System.Windows.Forms.Label();
            this.lblClubCount = new System.Windows.Forms.Label();
            this.lblClubRem = new System.Windows.Forms.Label();
            this.lblLowerCount = new System.Windows.Forms.Label();
            this.lblLowerRem = new System.Windows.Forms.Label();
            this.grpLookup = new System.Windows.Forms.GroupBox();
            this.btnFindGuest = new System.Windows.Forms.Button();
            this.txtConfirmNum = new System.Windows.Forms.TextBox();
            this.lblConfirmNum = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpRemaining.SuspendLayout();
            this.grpLookup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomer,
            this.colEmail,
            this.colTotalCost,
            this.colConfirm,
            this.colLower,
            this.colClub,
            this.colUpper});
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colTotalCost
            // 
            this.colTotalCost.HeaderText = "Total Cost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.ReadOnly = true;
            // 
            // colConfirm
            // 
            this.colConfirm.HeaderText = "Confirmation Number";
            this.colConfirm.Name = "colConfirm";
            this.colConfirm.ReadOnly = true;
            // 
            // colLower
            // 
            this.colLower.HeaderText = "Lower Level Seats";
            this.colLower.Name = "colLower";
            this.colLower.ReadOnly = true;
            // 
            // colClub
            // 
            this.colClub.HeaderText = "Club Level Seats";
            this.colClub.Name = "colClub";
            this.colClub.ReadOnly = true;
            // 
            // colUpper
            // 
            this.colUpper.HeaderText = "Upper Level Seats";
            this.colUpper.Name = "colUpper";
            this.colUpper.ReadOnly = true;
            // 
            // grpRemaining
            // 
            this.grpRemaining.Controls.Add(this.lblUpperCount);
            this.grpRemaining.Controls.Add(this.lblUpperRem);
            this.grpRemaining.Controls.Add(this.lblClubCount);
            this.grpRemaining.Controls.Add(this.lblClubRem);
            this.grpRemaining.Controls.Add(this.lblLowerCount);
            this.grpRemaining.Controls.Add(this.lblLowerRem);
            this.grpRemaining.Location = new System.Drawing.Point(12, 111);
            this.grpRemaining.Name = "grpRemaining";
            this.grpRemaining.Size = new System.Drawing.Size(448, 117);
            this.grpRemaining.TabIndex = 1;
            this.grpRemaining.TabStop = false;
            this.grpRemaining.Text = "Seats Remaining";
            // 
            // lblUpperCount
            // 
            this.lblUpperCount.AutoSize = true;
            this.lblUpperCount.Location = new System.Drawing.Point(342, 78);
            this.lblUpperCount.Name = "lblUpperCount";
            this.lblUpperCount.Size = new System.Drawing.Size(13, 13);
            this.lblUpperCount.TabIndex = 5;
            this.lblUpperCount.Text = "0";
            // 
            // lblUpperRem
            // 
            this.lblUpperRem.AutoSize = true;
            this.lblUpperRem.Location = new System.Drawing.Point(321, 33);
            this.lblUpperRem.Name = "lblUpperRem";
            this.lblUpperRem.Size = new System.Drawing.Size(68, 13);
            this.lblUpperRem.TabIndex = 4;
            this.lblUpperRem.Text = "Upper Level:";
            // 
            // lblClubCount
            // 
            this.lblClubCount.AutoSize = true;
            this.lblClubCount.Location = new System.Drawing.Point(210, 78);
            this.lblClubCount.Name = "lblClubCount";
            this.lblClubCount.Size = new System.Drawing.Size(13, 13);
            this.lblClubCount.TabIndex = 3;
            this.lblClubCount.Text = "0";
            // 
            // lblClubRem
            // 
            this.lblClubRem.AutoSize = true;
            this.lblClubRem.Location = new System.Drawing.Point(188, 33);
            this.lblClubRem.Name = "lblClubRem";
            this.lblClubRem.Size = new System.Drawing.Size(60, 13);
            this.lblClubRem.TabIndex = 2;
            this.lblClubRem.Text = "Club Level:";
            // 
            // lblLowerCount
            // 
            this.lblLowerCount.AutoSize = true;
            this.lblLowerCount.Location = new System.Drawing.Point(65, 78);
            this.lblLowerCount.Name = "lblLowerCount";
            this.lblLowerCount.Size = new System.Drawing.Size(13, 13);
            this.lblLowerCount.TabIndex = 1;
            this.lblLowerCount.Text = "0";
            // 
            // lblLowerRem
            // 
            this.lblLowerRem.AutoSize = true;
            this.lblLowerRem.Location = new System.Drawing.Point(43, 33);
            this.lblLowerRem.Name = "lblLowerRem";
            this.lblLowerRem.Size = new System.Drawing.Size(68, 13);
            this.lblLowerRem.TabIndex = 0;
            this.lblLowerRem.Text = "Lower Level:";
            // 
            // grpLookup
            // 
            this.grpLookup.Controls.Add(this.btnFindGuest);
            this.grpLookup.Controls.Add(this.txtConfirmNum);
            this.grpLookup.Controls.Add(this.lblConfirmNum);
            this.grpLookup.Location = new System.Drawing.Point(466, 111);
            this.grpLookup.Name = "grpLookup";
            this.grpLookup.Size = new System.Drawing.Size(322, 117);
            this.grpLookup.TabIndex = 2;
            this.grpLookup.TabStop = false;
            this.grpLookup.Text = "Guest Lookup";
            // 
            // btnFindGuest
            // 
            this.btnFindGuest.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFindGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindGuest.ForeColor = System.Drawing.Color.White;
            this.btnFindGuest.Location = new System.Drawing.Point(133, 68);
            this.btnFindGuest.Name = "btnFindGuest";
            this.btnFindGuest.Size = new System.Drawing.Size(64, 32);
            this.btnFindGuest.TabIndex = 8;
            this.btnFindGuest.Text = "Find";
            this.btnFindGuest.UseVisualStyleBackColor = false;
            this.btnFindGuest.Click += new System.EventHandler(this.BtnFindGuest_Click);
            // 
            // txtConfirmNum
            // 
            this.txtConfirmNum.Location = new System.Drawing.Point(172, 33);
            this.txtConfirmNum.Name = "txtConfirmNum";
            this.txtConfirmNum.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmNum.TabIndex = 7;
            // 
            // lblConfirmNum
            // 
            this.lblConfirmNum.AutoSize = true;
            this.lblConfirmNum.Location = new System.Drawing.Point(46, 36);
            this.lblConfirmNum.Name = "lblConfirmNum";
            this.lblConfirmNum.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmNum.TabIndex = 6;
            this.lblConfirmNum.Text = "Confirmation Number:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSales.Location = new System.Drawing.Point(75, 60);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(131, 25);
            this.lblTotalSales.TabIndex = 3;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(306, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(71, 25);
            this.lblTotalAmount.TabIndex = 4;
            this.lblTotalAmount.Text = "$0.00";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.grpLookup);
            this.Controls.Add(this.grpRemaining);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAdmin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpRemaining.ResumeLayout(false);
            this.grpRemaining.PerformLayout();
            this.grpLookup.ResumeLayout(false);
            this.grpLookup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpRemaining;
        private System.Windows.Forms.Label lblUpperCount;
        private System.Windows.Forms.Label lblUpperRem;
        private System.Windows.Forms.Label lblClubCount;
        private System.Windows.Forms.Label lblClubRem;
        private System.Windows.Forms.Label lblLowerCount;
        private System.Windows.Forms.Label lblLowerRem;
        private System.Windows.Forms.GroupBox grpLookup;
        private System.Windows.Forms.Button btnFindGuest;
        private System.Windows.Forms.TextBox txtConfirmNum;
        private System.Windows.Forms.Label lblConfirmNum;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpper;
    }
}