namespace Project7
{
    partial class frmOrder
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
            this.grpTickets = new System.Windows.Forms.GroupBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbxUpper = new System.Windows.Forms.ComboBox();
            this.cbxClub = new System.Windows.Forms.ComboBox();
            this.cbxLower = new System.Windows.Forms.ComboBox();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.grpTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTickets
            // 
            this.grpTickets.Controls.Add(this.btnBuy);
            this.grpTickets.Controls.Add(this.lblQuantity);
            this.grpTickets.Controls.Add(this.cbxUpper);
            this.grpTickets.Controls.Add(this.cbxClub);
            this.grpTickets.Controls.Add(this.cbxLower);
            this.grpTickets.Controls.Add(this.lblUpper);
            this.grpTickets.Controls.Add(this.lblClub);
            this.grpTickets.Controls.Add(this.lblLower);
            this.grpTickets.Location = new System.Drawing.Point(52, 46);
            this.grpTickets.Name = "grpTickets";
            this.grpTickets.Size = new System.Drawing.Size(338, 236);
            this.grpTickets.TabIndex = 0;
            this.grpTickets.TabStop = false;
            this.grpTickets.Text = "Tickets";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(93, 188);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(139, 33);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(239, 28);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 16);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbxUpper
            // 
            this.cbxUpper.FormattingEnabled = true;
            this.cbxUpper.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "Other"});
            this.cbxUpper.Location = new System.Drawing.Point(186, 148);
            this.cbxUpper.Name = "cbxUpper";
            this.cbxUpper.Size = new System.Drawing.Size(121, 21);
            this.cbxUpper.TabIndex = 5;
            this.cbxUpper.Text = "0";
            // 
            // cbxClub
            // 
            this.cbxClub.FormattingEnabled = true;
            this.cbxClub.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "Other"});
            this.cbxClub.Location = new System.Drawing.Point(186, 105);
            this.cbxClub.Name = "cbxClub";
            this.cbxClub.Size = new System.Drawing.Size(121, 21);
            this.cbxClub.TabIndex = 4;
            this.cbxClub.Text = "0";
            // 
            // cbxLower
            // 
            this.cbxLower.FormattingEnabled = true;
            this.cbxLower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "Other"});
            this.cbxLower.Location = new System.Drawing.Point(186, 57);
            this.cbxLower.Name = "cbxLower";
            this.cbxLower.Size = new System.Drawing.Size(121, 21);
            this.cbxLower.TabIndex = 3;
            this.cbxLower.Text = "0";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(14, 153);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(143, 16);
            this.lblUpper.TabIndex = 2;
            this.lblUpper.Text = "Upper Deck: $50.00";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(24, 106);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(133, 16);
            this.lblClub.TabIndex = 1;
            this.lblClub.Text = "Club Level: $75.00";
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(6, 57);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(151, 16);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "Lower Level: $125.00";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 390);
            this.Controls.Add(this.grpTickets);
            this.Name = "frmOrder";
            this.Text = "Order Tickets";
            this.grpTickets.ResumeLayout(false);
            this.grpTickets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTickets;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbxUpper;
        private System.Windows.Forms.ComboBox cbxClub;
        private System.Windows.Forms.ComboBox cbxLower;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Button btnBuy;
    }
}