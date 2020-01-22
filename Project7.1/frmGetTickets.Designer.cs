namespace Project7
{
    partial class frmGetTicket
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGetTicket = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(131, 103);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(268, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Forensic Tuesday";
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetTicket.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTicket.ForeColor = System.Drawing.Color.White;
            this.btnGetTicket.Location = new System.Drawing.Point(184, 203);
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Size = new System.Drawing.Size(169, 50);
            this.btnGetTicket.TabIndex = 1;
            this.btnGetTicket.Text = "Get Tickets";
            this.btnGetTicket.UseVisualStyleBackColor = false;
            this.btnGetTicket.Click += new System.EventHandler(this.BtnGetTicket_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAdmin.Location = new System.Drawing.Point(35, 32);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.LblAdmin_Click);
            // 
            // frmGetTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 388);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnGetTicket);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmGetTicket";
            this.Text = "Get Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGetTicket;
        private System.Windows.Forms.Label lblAdmin;
    }
}

