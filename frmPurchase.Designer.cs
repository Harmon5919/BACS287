namespace Project7
{
    partial class frmPurchase
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCreditCardNum = new System.Windows.Forms.Label();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.lblCSV = new System.Windows.Forms.Label();
            this.txtCreditCardNum = new System.Windows.Forms.TextBox();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(198, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 19);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Cost:";
            // 
            // lblCreditCardNum
            // 
            this.lblCreditCardNum.AutoSize = true;
            this.lblCreditCardNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditCardNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCreditCardNum.Location = new System.Drawing.Point(67, 112);
            this.lblCreditCardNum.Name = "lblCreditCardNum";
            this.lblCreditCardNum.Size = new System.Drawing.Size(167, 19);
            this.lblCreditCardNum.TabIndex = 1;
            this.lblCreditCardNum.Text = "Credit Card Number:";
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOnCard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNameOnCard.Location = new System.Drawing.Point(108, 157);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(126, 19);
            this.lblNameOnCard.TabIndex = 2;
            this.lblNameOnCard.Text = "Name On Card:";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCSV.Location = new System.Drawing.Point(186, 201);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(48, 19);
            this.lblCSV.TabIndex = 3;
            this.lblCSV.Text = "CSV:";
            // 
            // txtCreditCardNum
            // 
            this.txtCreditCardNum.Location = new System.Drawing.Point(258, 110);
            this.txtCreditCardNum.Name = "txtCreditCardNum";
            this.txtCreditCardNum.Size = new System.Drawing.Size(191, 20);
            this.txtCreditCardNum.TabIndex = 4;
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(258, 158);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(191, 20);
            this.txtNameOnCard.TabIndex = 5;
            // 
            // txtCSV
            // 
            this.txtCSV.Location = new System.Drawing.Point(258, 202);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(191, 20);
            this.txtCSV.TabIndex = 6;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(287, 241);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(139, 29);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Submit Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCost.Location = new System.Drawing.Point(296, 49);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(54, 20);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "$0.00";
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 350);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtCSV);
            this.Controls.Add(this.txtNameOnCard);
            this.Controls.Add(this.txtCreditCardNum);
            this.Controls.Add(this.lblCSV);
            this.Controls.Add(this.lblNameOnCard);
            this.Controls.Add(this.lblCreditCardNum);
            this.Controls.Add(this.lblTotal);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmPurchase";
            this.Text = "Purchase Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCreditCardNum;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.TextBox txtCreditCardNum;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTotalCost;
    }
}